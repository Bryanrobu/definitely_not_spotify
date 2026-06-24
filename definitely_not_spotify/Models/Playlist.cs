namespace definitely_not_spotify.Models
{
    public class Playlist
    {
        private string Name { get; set; }
        private User CreatedBy { get; set; }
        private List<Song> Songs { get; set; }

        public Playlist(string name, User createdBy)
        {
            Name = name;
            CreatedBy = createdBy;
            Songs = new List<Song>();
        }

        public void AddSong(Song s) => Songs.Add(s);

        public void RemoveSong(Song s) => Songs.Remove(s);

        public List<Song> GetSongs() => Songs;

        public override string ToString() => Name;
    }
}
