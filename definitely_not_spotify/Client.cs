using definitely_not_spotify.Models;

namespace definitely_not_spotify
{
    public class Client
    {
        public List<User> Users { get; }
        public User CurrentUser { get; private set; }
        public List<Song> Songs { get; }

        public Client()
        {
            Users = new List<User>();
            Songs = new List<Song>();
            Songs.AddRange(TestData.GetSongs());
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
    }
}
