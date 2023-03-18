using System.Collections;

namespace Music_library_schema.Entities
{
    public class Songs
    {
        public int ID { get; set; }
        public string SongName { get; set; }
        public string GenreOfSong { get; set; }
        public Artists Artist { get; set; }
        public Albums Albums { get; set; }
        public Playlists Playlist { get; set; }

    }
}
