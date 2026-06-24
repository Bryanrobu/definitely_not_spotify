using System.Security.Cryptography.X509Certificates;

namespace definitely_not_spotify.Models
{
    public class Song
    {
        public string Title { get; set; }
        public string Artists { get; set; }
        public Genre Genre { get; set; }

        public string Display => $"{Title} - {Artists}";

        public Song(string title, Genre genre, string artists)
        {
            Title = title;
            Genre = genre;
            Artists = artists;
        }

        public Song(string title, Genre genre, Artist artist)
        {
            Title = title;
            Genre = genre;
            Artists = artist.Name;
        }
    }
}
