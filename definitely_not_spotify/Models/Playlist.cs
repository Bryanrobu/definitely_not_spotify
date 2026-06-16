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

        public void AddPlaylist(Playlist p)
        {
            foreach (var song in p.Songs)
            {
                Songs.Add(song);
            }
        }

        public void RemoveSong(Song s) => Songs.Remove(s);

        public void PlayPlaylist()
        {

        }

        public string GetName()
        {
            return Name;
        }

        public override string ToString()
        {
            return GetName();
        }
    }
}
