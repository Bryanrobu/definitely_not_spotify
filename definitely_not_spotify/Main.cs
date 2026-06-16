using definitely_not_spotify.Models;

namespace definitely_not_spotify
{
    public partial class Main : Form
    {
        private User user;
        private Client client;
        public Main()
        {
            InitializeComponent();
            nowPlaying.Text = "Nothing is playing" + Environment.NewLine + "no artist";
        }

        public Main(Client client) : this()
        {
            this.client = client;
            user = client.CurrentUser;
            currentUser.Text = this.user.Username;
            FillUsers();
            FillDiscover();
            FillPlaylists();
        }

        private void play_pause_Click(object sender, EventArgs e)
        {

        }

        private void skip_Click(object sender, EventArgs e)
        {

        }

        private void return_Click(object sender, EventArgs e)
        {

        }

        private void Playlists_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Users_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void search_KeyUp(object sender, KeyEventArgs e)
        {

        }
        private void FillUsers()
        {
            Users.Items.Clear();
            Users.DisplayMember = "Username";
            foreach (var user in client.Users)
            {
                if (user.Username != this.user.Username)
                {
                    Users.Items.Add(user);
                }
            }
        }

        private void FillDiscover()
        {
            Discover.Items.Clear();
            Discover.DisplayMember = "Display";
            foreach (var song in client.Songs)
            {
                Discover.Items.Add(song);
            }
        }

        private void FillPlaylists()
        {
            Playlists.Items.Clear();
            foreach (var playlist in user.Playlists)
            {
                Playlists.Items.Add(playlist);
            }
        }

        private void logout_Click(object sender, EventArgs e)
        {
            client.Logout();
            new Login(client).Show();
            Close();
        }

        private void add_playlist_Click(object sender, EventArgs e)
        {
            using (var form = new CreatePlaylistForm())
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    var playlist = client.CreatePlaylist(form.PlaylistName);

                    if (playlist == null)
                    {
                        MessageBox.Show("Geef een geldige naam op.");
                        return;
                    }

                    FillPlaylists();
                }
            }
        }

        private void delete_playlist_Click(object sender, EventArgs e)
        {
            if (Playlists.SelectedItem == null)
            {
                MessageBox.Show("Selecteer eerst een playlist.");
                return;
            }

            var result = MessageBox.Show("Weet je het zeker?", "Playlist verwijderen", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                var playlist = (Playlist)Playlists.SelectedItem;
                client.DeletePlaylist(playlist);
                FillPlaylists();
            }
        }
    }
}
