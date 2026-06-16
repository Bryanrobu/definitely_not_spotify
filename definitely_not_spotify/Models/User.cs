namespace definitely_not_spotify.Models
{
    public class User
    {
        public string Username { get; set; }
        public List<Playlist> Playlists { get; set; }
        public List<User> Friends { get; set; }

        public User(string username)
        {
            Username = username;
            Playlists = new List<Playlist>();
            Friends = new List<User>();
        }

        public void AddFriend(User u) => Friends.Add(u);

        public void RemoveFriend(User u) => Friends.Remove(u);

        public void AcceptFriend(User u)
        {
            if (!Friends.Contains(u))
            {
                Friends.Add(u);
            }
        }
    }
}
