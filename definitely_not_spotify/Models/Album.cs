namespace definitely_not_spotify.Models
{
    public class Album
    {
        public string Title { get; set; }
        public List<Song> Songs { get; set; }
        public Artist Artist { get; set; }

        public Album(string title, Artist artist)
        {
            Title = title;
            Artist = artist;
            Songs = new List<Song>();
        }

        public void SetTitle(string title) => Title = title;

        public List<Song> GetSongs() => Songs;

        public Artist GetArtist() => Artist;
    }
}
