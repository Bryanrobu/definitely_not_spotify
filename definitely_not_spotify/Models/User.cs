namespace definitely_not_spotify.Models
{
    public class User
    {
        public string Username { get; private set; }
        public List<Playlist> Playlists { get; private set; }
        public List<User> Friends { get; private set; }
        public List<User> FriendRequests { get; private set; }

        public User(string username)
        {
            Username = username;
            Playlists = new List<Playlist>();
            Friends = new List<User>();
            FriendRequests = new List<User>();
        }
    }
}
