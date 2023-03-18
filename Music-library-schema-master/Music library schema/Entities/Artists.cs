namespace Music_library_schema.Entities
{
    public class Artists
    {
        public int ID { get; set; }
        public string ArtistsName { get; set; }
        public string ArtistsLastName { get; set; }
        public int ArtistsAge { get; set; }
        public int SongsID { get; set; }
        public List<Songs> Songs { get; set; }
        public int AlbumsID { get; set; }
        public List<Albums> Albums { get; set; }    

    }
}
