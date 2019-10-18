using LiteDB;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Media_Organiser
{
    static class DatabaseManager
    {

        private static string DATABASE_LOCATION = @".\\Database.db";
        private static string MEDIA_TABLE = "media";
        private static string PLAYLIST_TABLE = "playlist";
        private static string PLAYLIST_SONG_TABLE = "playlistsong";
        private static string SETTINGS_TABLE = "settings";

        public static string DIR_SETTING = "directory";
        public static string TYPE_SETTING = "filetype";

        public static Objects.Record UploadFile(string fileDir, string name, string extension)
        {
            using (LiteDatabase db = new LiteDatabase(DATABASE_LOCATION))
            {
                var records = db.GetCollection<Objects.Record>(MEDIA_TABLE);

                Objects.Record record = new Objects.Record(name.GetHashCode().ToString(), name, fileDir, extension, DateTime.Now);

                bool success = false;

                success = records.Upsert(record);

                if (db.FileStorage.Exists(name.GetHashCode().ToString()))
                    db.FileStorage.Delete(name.GetHashCode().ToString());
                
                try
                {
                    db.FileStorage.Upload(name.GetHashCode().ToString(), name);
                } catch (Exception e)
                {
                    success = false;
                    Console.Write(e);
                }

                if (!success)
                    return record;
                return null;
            }
        }

        public static void AddPlaylist(string name)
        {
            using (LiteDatabase db = new LiteDatabase(DATABASE_LOCATION))
            {
                var collection = db.GetCollection<Objects.Playlist>(PLAYLIST_TABLE);
                Objects.Playlist playlist = new Objects.Playlist(name.GetHashCode().ToString(), name);

                collection.Upsert(playlist);
            }
        }

        public static void DeletePlaylist(string name)
        {
            using (LiteDatabase db = new LiteDatabase(DATABASE_LOCATION))
            {
                var collection = db.GetCollection<Objects.Playlist>(PLAYLIST_TABLE);
                var playlistSongs = db.GetCollection<Objects.PlaylistSong>(PLAYLIST_SONG_TABLE);
                collection.Delete(name.GetHashCode().ToString());
                playlistSongs.Delete(x => x.playlistId.Equals(name.GetHashCode().ToString()));
            }
        }

        public static ArrayList GetAllRecords()
        {
            using (LiteDatabase db = new LiteDatabase(DATABASE_LOCATION))
            {
                var records = db.GetCollection<Objects.Record>(MEDIA_TABLE);

                ArrayList list = new ArrayList();

                IEnumerator enumerator = records.FindAll().GetEnumerator();

                while (enumerator.MoveNext())
                    list.Add(enumerator.Current);

                return list;
            }
        }

        public static ArrayList GetRecordFiltered(string search)
        {
            using (LiteDatabase db = new LiteDatabase(DATABASE_LOCATION))
            {
                var records = db.GetCollection<Objects.Record>(MEDIA_TABLE);

                ArrayList list = new ArrayList();

                IEnumerator enumerator = records.Find(x => x.name.ToLower().Contains(search.ToLower())).GetEnumerator();

                while (enumerator.MoveNext())
                    list.Add(enumerator.Current);

                return list;
            }
        }

        public static ArrayList GetAllPlaylists()
        {
            using (LiteDatabase db = new LiteDatabase(DATABASE_LOCATION))
            {
                var playlists = db.GetCollection<Objects.Playlist>(PLAYLIST_TABLE);
                var playlistSongs = db.GetCollection<Objects.PlaylistSong>(PLAYLIST_SONG_TABLE);

                ArrayList list = new ArrayList();
                

                foreach (Objects.Playlist playlist in playlists.FindAll())
                {
                    int count = playlistSongs.Count(x => x.playlistId.Equals(playlist.id));
                    Dictionary<Objects.Playlist, int> dictionary = new Dictionary<Objects.Playlist, int>();
                    dictionary.Add(playlist, count);
                    list.Add(dictionary);
                }

                return list;
            }
        }

        public static ArrayList GetPlaylistsFiltered(string search)
        {
            using (LiteDatabase db = new LiteDatabase(DATABASE_LOCATION))
            {
                var playlists = db.GetCollection<Objects.Playlist>(PLAYLIST_TABLE);
                var playlistSongs = db.GetCollection<Objects.PlaylistSong>(PLAYLIST_SONG_TABLE);

                ArrayList list = new ArrayList();

                foreach (Objects.Playlist playlist in playlists.Find(x => x.name.ToLower().Contains(search.ToLower())))
                {
                    int count = playlistSongs.Count(x => x.playlistId.Equals(playlist.id));
                    Dictionary<Objects.Playlist, int> dictionary = new Dictionary<Objects.Playlist, int>();
                    dictionary.Add(playlist, count);
                    list.Add(dictionary);
                }

                return list;
            }
        }

        public static void RemoveRecords(ArrayList list)
        {
            using (LiteDatabase db = new LiteDatabase(DATABASE_LOCATION))
            {
                var collection = db.GetCollection<Objects.Record>(MEDIA_TABLE);
                var playlistrecords = db.GetCollection<Objects.PlaylistSong>(PLAYLIST_SONG_TABLE);
                foreach (string fn in list)
                {
                    collection.Delete(x => x.id.Equals(fn.GetHashCode().ToString()));
                    playlistrecords.Delete(x => x.mediaId.Equals(fn.GetHashCode().ToString()));
                    db.FileStorage.Delete(fn.GetHashCode().ToString());
                }
            }
        }

        public static void RemovePlaylist(ArrayList list)
        {
            using (LiteDatabase db = new LiteDatabase(DATABASE_LOCATION))
            {
                var collection = db.GetCollection<Objects.Playlist>(PLAYLIST_TABLE);
                var musicInPlaylist = db.GetCollection<Objects.PlaylistSong>(PLAYLIST_SONG_TABLE);
                foreach (string pl in list)
                {
                    collection.Delete(x => x.id.Equals(pl.GetHashCode().ToString()));
                    musicInPlaylist.Delete(x => x.playlistId.Equals(pl.GetHashCode().ToString()));
                }
            }
        }
        
        public static void UpdateSettings(string id, string setting)
        {
            using (LiteDatabase db = new LiteDatabase(DATABASE_LOCATION))
            {
                var settings = db.GetCollection<Objects.Settings>(SETTINGS_TABLE);
                if (!String.IsNullOrEmpty(id) && !String.IsNullOrEmpty(setting))
                {
                    Objects.Settings cSetting = new Objects.Settings(id, setting);
                    settings.Upsert(cSetting);
                }
            }
        }

        public static string GetSettings(string id)
        {
            using (LiteDatabase db = new LiteDatabase(DATABASE_LOCATION))
            {
                var settings = db.GetCollection<Objects.Settings>(SETTINGS_TABLE);
                if (!String.IsNullOrEmpty(id) && settings.Exists(x => x.id.Equals(id)))
                {
                    return settings.FindOne(x => x.id.Equals(id)).setting;
                }
                return "";
            }
        }

        public static ArrayList GetSongsInPlaylist(string playlistName)
        {
            using (LiteDatabase db = new LiteDatabase(DATABASE_LOCATION))
            {
                ArrayList list = new ArrayList();

                if (!String.IsNullOrEmpty(playlistName))
                {
                    var playlistTable = db.GetCollection<Objects.Playlist>(PLAYLIST_TABLE);
                    var playlistSongTable = db.GetCollection<Objects.PlaylistSong>(PLAYLIST_SONG_TABLE);
                    var record = db.GetCollection<Objects.Record>(MEDIA_TABLE);

                    Objects.Playlist playlist = playlistTable.FindById(playlistName.GetHashCode().ToString());

                    ArrayList playlistSongs = new ArrayList();

                    foreach (Objects.PlaylistSong ps in playlistSongTable.Find(x => x.playlistId.Equals(playlist.id)))
                        playlistSongs.Add(ps);

                    foreach (Objects.PlaylistSong ps in playlistSongs)
                        list.Add(record.FindById(ps.mediaId));
                }

                return list;
            }
        }

        public static void RemoveRecordFromPlaylist(string playlistName, string songName)
        {
            using (LiteDatabase db = new LiteDatabase(DATABASE_LOCATION))
            {
                var playlistTable = db.GetCollection<Objects.Playlist>(PLAYLIST_TABLE);
                var playlistSongTable = db.GetCollection<Objects.PlaylistSong>(PLAYLIST_SONG_TABLE);
                var recordTable = db.GetCollection<Objects.Record>(MEDIA_TABLE);

                Objects.Playlist playlist = playlistTable.FindOne(x => x.id.Equals(playlistName.GetHashCode().ToString()));
                Objects.Record record = recordTable.FindOne(x => x.id.Equals(songName.GetHashCode().ToString()));

                playlistSongTable.Delete(x => x.playlistId.Equals(playlist.id) && x.mediaId.Equals(record.id));
            }
        }

        public static void SetRecordToPlaylist(string playlistName, ArrayList records)
        {
            using (LiteDatabase db = new LiteDatabase(DATABASE_LOCATION))
            {
                var playlistTable = db.GetCollection<Objects.Playlist>(PLAYLIST_TABLE);
                var playlistSongTable = db.GetCollection<Objects.PlaylistSong>(PLAYLIST_SONG_TABLE);
                var recordTable = db.GetCollection<Objects.Record>(MEDIA_TABLE);

                foreach (string recordName in records)
                {
                    Objects.Playlist playlist = playlistTable.FindById(playlistName.GetHashCode().ToString());
                    Objects.Record record = recordTable.FindById(recordName.GetHashCode().ToString());
                    Objects.PlaylistSong playlistSong = new Objects.PlaylistSong(playlist.id+record.id, record.id, playlist.id);
                    playlistSongTable.Upsert(playlistSong);
                }
            }
        }

    }
}
