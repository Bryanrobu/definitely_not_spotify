namespace definitely_not_spotify.Models
{
    public class Song
    {
        public string Title { get; private set; }
        public string Artists { get; private set; }
        public Genre Genre { get; private set; }

        public string Display => $"{Title} - {Artists}";

        public Song(string title, Genre genre, string artists)
        {
            Title = title;
            Genre = genre;
            Artists = artists;
        }
    }
}
