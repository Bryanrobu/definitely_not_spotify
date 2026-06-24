namespace definitely_not_spotify.Models
{
    public class Album
    {
        public string Title { get; private set; }
        public List<Song> Songs { get; private set; }
        public Artist Artist { get; private set; }

        public Album(string title, Artist artist)
        {
            Title = title;
            Artist = artist;
            Songs = new List<Song>();
        }

        public void AddSong(Song s) => Songs.Add(s);

        public override string ToString() => Title;
    }
}
