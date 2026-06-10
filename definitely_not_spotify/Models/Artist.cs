namespace definitely_not_spotify.Models
{
    public class Artist
    {
        public string Name { get; set; }
        public List<Song> Songs { get; set; }
        public List<Album> Albums { get; set; }

        public Artist(string name)
        {
            Name = name;
            Songs = new List<Song>();
            Albums = new List<Album>();
        }

        public string GetName() => Name;

        public List<Song> GetSongs() => Songs;

        public List<Album> GetAlbums() => Albums;
    }
}
