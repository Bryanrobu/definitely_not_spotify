using definitely_not_spotify.Models;

namespace definitely_not_spotify
{
    public partial class Main : Form
    {
        private User user;
        private Client client;
        private Song currentSong;
        private Song selectedSong;
        private bool isPlaying;
        public Main()
        {
            InitializeComponent();
            nowPlaying.Text = "Nothing is playing" + Environment.NewLine + "no artist";
            Discover.SelectedIndexChanged += Song_SelectedIndexChanged;
            Numbers.SelectedIndexChanged += Song_SelectedIndexChanged;
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

        private void Song_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is ListBox list && list.SelectedItem is Song song)
            {
                selectedSong = song;
            }
        }

        private void play_pause_Click(object sender, EventArgs e)
        {
            if (selectedSong != null && selectedSong != currentSong)
            {
                currentSong = selectedSong;
                isPlaying = true;
            }
            else if (currentSong != null)
            {
                isPlaying = !isPlaying;
            }
            UpdateNowPlaying();
        }

        private void UpdateNowPlaying()
        {
            if (currentSong == null)
            {
                nowPlaying.Text = "Nothing is playing" + Environment.NewLine + "no artist";
                return;
            }

            string status = isPlaying ? "Playing" : "Paused";
            nowPlaying.Text = status + ": " + currentSong.Title + Environment.NewLine + currentSong.Artists;
        }

        private void skip_Click(object sender, EventArgs e)
        {
            if (currentSong == null) return;
            int index = client.Songs.IndexOf(currentSong);
            if (index + 1 < client.Songs.Count)
                currentSong = client.Songs[index + 1];
            selectedSong = currentSong;
            isPlaying = true;
            UpdateNowPlaying();
        }

        private void return_Click(object sender, EventArgs e)
        {
            if (currentSong == null) return;
            int index = client.Songs.IndexOf(currentSong);
            if (index - 1 > 0)
                currentSong = client.Songs[index - 1];
            selectedSong = currentSong;
            isPlaying = true;
            UpdateNowPlaying();
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
