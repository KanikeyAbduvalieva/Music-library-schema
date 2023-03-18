namespace Music_library_schema.Entities
{
    public class Playlists
    {
        public int ID { get; set; }
        public string PlaylistName { get; set; }
        public string GenrePlaylist { get; set; }
        public int PlaylistsSongsNumber { get; set; }  
        public List<Songs> Songs { get; set; }
        public int AlbumsID { get; set; }
        public List<Albums> Albums { get; set; }

    }
}
