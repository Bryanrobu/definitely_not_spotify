namespace definitely_not_spotify.Models
{
    public class Artist
    {
        public string Name { get; private set; }
        public List<Song> Songs { get; private set; }
        public List<Album> Albums { get; private set; }

        public Artist(string name)
        {
            Name = name;
            Songs = new List<Song>();
            Albums = new List<Album>();
        }

        public void AddSong(Song s) => Songs.Add(s);
        public void AddAlbum(Album a) => Albums.Add(a);

        public override string ToString() => Name;
    }
}
