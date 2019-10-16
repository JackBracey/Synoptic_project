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

        public static Objects.Record UploadFile(string fileDir, string name, string extension)
        {
            using (LiteDatabase db = new LiteDatabase(DATABASE_LOCATION))
            {
                var records = db.GetCollection<Objects.Record>(MEDIA_TABLE);

                String filename = fileDir + @"\" + name;
                Objects.Record record = new Objects.Record(filename.GetHashCode().ToString(), name, fileDir, extension, DateTime.Now);

                bool success = false;

                success = records.Upsert(record);
                
                db.FileStorage.Upload(filename.GetHashCode().ToString(), filename);

                if (success)
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

        public static ArrayList GetAllPlaylists()
        {
            using (LiteDatabase db = new LiteDatabase(DATABASE_LOCATION))
            {
                var playlists = db.GetCollection<Objects.Playlist>(PLAYLIST_TABLE);
                var playlistSongs = db.GetCollection<Objects.PlaylistSong>(PLAYLIST_SONG_TABLE);

                ArrayList list = new ArrayList();

                IEnumerator playlistEnumerator = playlists.FindAll().GetEnumerator();

                while (playlistEnumerator.MoveNext())
                {
                    int count = playlistSongs.Count(x => x.playlistId.Equals(playlistEnumerator.Current/*Need to check the id here!*/));
                    Dictionary<object, int> dictionary = new Dictionary<object, int>();
                    dictionary.Add(playlistEnumerator.Current, 1);
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
                foreach (string fn in list)
                {
                    collection.Delete(x => x.id.Equals(fn.GetHashCode().ToString()));
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
    }
}
