﻿using System;

namespace Media_Organiser
{
    class Objects
    {

        public class Record
        {
            public Record(string id, string name, string path, string type, DateTime dateAdded)
            {
                this.id = id;
                this.name = name;
                this.path = path;
                this.type = type;
                this.dateAdded = dateAdded;
            }

            public Record() { }

            public string id { get; set; }
            public string name { get; set; }
            public string path { get; set; }
            public string type { get; set; }
            public DateTime dateAdded { get; set; }
        }

        public class Playlist
        {
            public Playlist(string id, string name)
            {
                this.id = id;
                this.name = name;
            }
            public Playlist() { }
            public string id { get; set; }
            public string name { get; set; }
        }

        public class PlaylistSong
        {
            public PlaylistSong(string mediaId, string playlistId)
            {
                this.mediaId = mediaId;
                this.playlistId = playlistId;
            }
            public PlaylistSong() { }
            public string mediaId { get; set; }
            public string playlistId { get; set; }
        }

    }
}
