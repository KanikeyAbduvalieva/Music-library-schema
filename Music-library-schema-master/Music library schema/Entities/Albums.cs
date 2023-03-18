namespace Music_library_schema.Entities
{
    public class Albums
    { 
        public int ID { get; set; }
        public string AlbumsName { get; set; }
        public int AlbumsSongsNumber { get; set; }
        public List<Songs> Song { get; set; }
        public Artists Artist { get; set; }
        public Playlists Playlist { get; set; }
    }
}
