using definitely_not_spotify.Models;

namespace definitely_not_spotify
{
    public class Client
    {
        public List<User> Users { get; }
        public User CurrentUser { get; private set; }
        public List<Song> Songs { get; }
        public List<Artist> Artists { get; }

        public List<Playlist> playlists { get; }

        public Client()
        {
            Users = new List<User>();
            Songs = new List<Song>();
            playlists = new List<Playlist>();
            Artists = new List<Artist>();
            Songs.AddRange(TestData.GetSongs());
            Users.AddRange(TestData.GetUsers());
            Artists.AddRange(TestData.GetArtists());
        }

        public User CreateUser(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                return null;
            }

            if (Users.Any(u => u.Username == username))
            {
                return null;
            }

            var user = new User(username);
            Users.Add(user);
            return user;
        }

        public User Login(string username)
        {
            var user = Users.FirstOrDefault(u => u.Username == username);
            CurrentUser = user;
            return user;
        }

        public void Logout()
        {
            CurrentUser = null;
        }

        public Playlist CreatePlaylist(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return null;
            }

            var playlist = new Playlist(name, CurrentUser);
            CurrentUser.Playlists.Add(playlist);
            playlists.Add(playlist);

            return playlist;
        }

        public void DeletePlaylist(Playlist playlist)
        {
            CurrentUser.Playlists.Remove(playlist);
            playlists.Remove(playlist);
        }

        public void SendFriendRequest(User to)
        {
            if (to == CurrentUser) return;
            if (CurrentUser.Friends.Contains(to)) return;
            if (to.FriendRequests.Contains(CurrentUser)) return;
            to.FriendRequests.Add(CurrentUser);
        }

        public void AcceptFriendRequest(User from)
        {
            CurrentUser.FriendRequests.Remove(from);
            CurrentUser.Friends.Add(from);
            from.Friends.Add(CurrentUser);
        }

        public void DeclineFriendRequest(User from)
        {
            CurrentUser.FriendRequests.Remove(from);
        }
    }
}
