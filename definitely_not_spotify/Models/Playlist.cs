namespace definitely_not_spotify.Models
{
    public class Playlist
    {
        public string Name { get; private set; }
        public User CreatedBy { get; private set; }
        public List<Song> Songs { get; private set; }

        public Playlist(string name, User createdBy)
        {
            Name = name;
            CreatedBy = createdBy;
            Songs = new List<Song>();
        }

        public void AddSong(Song s) => Songs.Add(s);
        public void RemoveSong(Song s) => Songs.Remove(s);

        public override string ToString() => Name;
    }
}
