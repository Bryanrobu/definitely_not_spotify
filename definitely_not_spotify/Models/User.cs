namespace definitely_not_spotify.Models
{
    public class User
    {
        public string Username { get; set; }
        public List<Playlist> Playlists { get; set; }
        public List<User> Friends { get; set; }
        public List<User> FriendRequests { get; set; }

        public User(string username)
        {
            Username = username;
            Playlists = new List<Playlist>();
            Friends = new List<User>();
            FriendRequests = new List<User>();
        }
    }
}
