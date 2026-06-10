namespace definitely_not_spotify.Models
{
    public class Song
    {
        public string Title { get; set; }
        public List<Artist> Artists { get; set; }
        public Genre Genre { get; set; }

        public Song(string title, Genre genre)
        {
            Title = title;
            Genre = genre;
            Artists = new List<Artist>();
        }

        public List<Artist> GetArtists() => Artists;

        public string GetTitle() => Title;

        public Genre GetGenre() => Genre;
    }
}
