using definitely_not_spotify.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace definitely_not_spotify
{
    public partial class Main : Form
    {
        private User user;
        private Client client;
        private Song currentSong;
        private Song selectedSong;
        private bool isPlaying;
        private ListBox activeList;
        private ListBox playingList;
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
            FillFriendRequests();
            FillFriends();
            FillArtists();
        }

        private void Song_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is ListBox list && list.SelectedItem is Song song)
            {
                selectedSong = song;
                activeList = list;

                if (list != Discover) Discover.ClearSelected();
                if (list != Numbers) Numbers.ClearSelected();
                if (list != Songs) Songs.ClearSelected();
            }
        }

        private void play_pause_Click(object sender, EventArgs e)
        {
            if (selectedSong != null && selectedSong != currentSong)
            {
                currentSong = selectedSong;
                playingList = activeList;
                isPlaying = true;
            }
            else if (currentSong != null)
            {
                isPlaying = !isPlaying;
            }
            else if (Numbers.Items.Count > 0)
            {
                currentSong = (Song)Numbers.Items[0];
                playingList = Numbers;
                isPlaying = true;
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
            if (playingList == null || currentSong == null) return;
            int i = playingList.Items.IndexOf(currentSong) + 1;
            if (i < playingList.Items.Count)
            {
                currentSong = (Song)playingList.Items[i];
                isPlaying = true;
                UpdateNowPlaying();
            }
        }

        private void return_Click(object sender, EventArgs e)
        {
            if (playingList == null || currentSong == null) return;
            int i = playingList.Items.IndexOf(currentSong) - 1;
            if (i >= 0)
            {
                currentSong = (Song)playingList.Items[i];
                isPlaying = true;
                UpdateNowPlaying();
            }
        }

        private void Playlists_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Playlists.SelectedItem is Playlist playlist)
            {
                ShowPlaylistSongs(playlist);
                selectedSong = null;
                Discover.ClearSelected();
                Numbers.ClearSelected();
            }
        }

        private void ShowPlaylistSongs(Playlist playlist)
        {
            Numbers.Items.Clear();
            Numbers.DisplayMember = "Display";
            foreach (var song in playlist.GetSongs())
            {
                Numbers.Items.Add(song);
            }
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

        private void FillArtists()
        {
            artists.Items.Clear();
            artists.DisplayMember = "Name";
            foreach (var artist in client.Artists)
            {
                artists.Items.Add(artist);
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
                Numbers.Items.Clear();
            }
        }

        private void addSong_Click(object sender, EventArgs e)
        {
            if (selectedSong != null && Playlists.SelectedItem is Playlist playlist)
            {
                if (playlist.GetSongs().Contains(selectedSong))
                {
                    var result = MessageBox.Show(
                        "Dit nummer staat al in de playlist. Toch toevoegen?",
                        "Dubbel nummer",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.No)
                    {
                        return;
                    }
                }
                playlist.AddSong(selectedSong);
                ShowPlaylistSongs(playlist);
            }
        }

        private void removeSong_Click(object sender, EventArgs e)
        {
            if (Numbers.SelectedItem is Song song && Playlists.SelectedItem is Playlist playlist)
            {
                playlist.RemoveSong(song);
                ShowPlaylistSongs(playlist);
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            this.currentSong = null;
            this.playingList = null;
            nowPlaying.Text = "Nothing is playing" + Environment.NewLine + "no artist";
        }

        private void FillFriendRequests()
        {
            FriendRequests.Items.Clear();
            FriendRequests.DisplayMember = "Username";
            foreach (var u in user.FriendRequests)
            {
                FriendRequests.Items.Add(u);
            }
        }

        private void FillFriends()
        {
            FriendsList.Items.Clear();
            FriendsList.DisplayMember = "Username";
            foreach (var u in user.Friends)
            {
                FriendsList.Items.Add(u);
            }
        }

        private void FriendsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            FriendPlaylists.Items.Clear();
            FriendSongs.Items.Clear();
            if (FriendsList.SelectedItem is User friend)
            {
                foreach (var p in friend.Playlists)
                {
                    FriendPlaylists.Items.Add(p);
                }
            }
        }

        private void FriendPlaylists_SelectedIndexChanged(object sender, EventArgs e)
        {
            FriendSongs.Items.Clear();
            FriendSongs.DisplayMember = "Display";
            if (FriendPlaylists.SelectedItem is Playlist playlist)
            {
                foreach (var s in playlist.GetSongs())
                {
                    FriendSongs.Items.Add(s);
                }
            }
        }

        private void AddFriend_Click(object sender, EventArgs e)
        {
            if (Users.SelectedItem is User target)
            {
                client.SendFriendRequest(target);
            }
        }

        private void AcceptFriend_Click(object sender, EventArgs e)
        {
            if (FriendRequests.SelectedItem is User from)
            {
                client.AcceptFriendRequest(from);
                FillFriendRequests();
                FillFriends();
            }
        }

        private void DeclineFriend_Click(object sender, EventArgs e)
        {
            if (FriendRequests.SelectedItem is User from)
            {
                client.DeclineFriendRequest(from);
                FillFriendRequests();
            }
        }

        private void addFriendSong_Click(object sender, EventArgs e)
        {
            if (FriendSongs.SelectedItem is Song song && Playlists.SelectedItem is Playlist myPlaylist)
            {
                if (myPlaylist.GetSongs().Contains(song))
                {
                    var result = MessageBox.Show(
                        "Dit nummer staat al in de playlist. Toch toevoegen?",
                        "Dubbel nummer",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.No)
                    {
                        return;
                    }
                }
                myPlaylist.AddSong(song);
                ShowPlaylistSongs(myPlaylist);
            }
        }

        private void addFriendPlaylist_Click(object sender, EventArgs e)
        {
            if (FriendPlaylists.SelectedItem is Playlist friendPlaylist && Playlists.SelectedItem is Playlist myPlaylist)
            {
                foreach (var song in friendPlaylist.GetSongs())
                {
                    if (myPlaylist.GetSongs().Contains(song))
                    {
                        var result = MessageBox.Show(
                            $"\"{song.Title}\" staat al in de playlist. Toch toevoegen?",
                            "Dubbel nummer",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.No)
                        {
                            continue;
                        }
                    }
                    myPlaylist.AddSong(song);
                }
                ShowPlaylistSongs(myPlaylist);
                ShowPlaylistSongs(myPlaylist);
            }
        }
        private void Artists_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (artists.SelectedItem is Artist artist)
            {
                Albums.Items.Clear();
                Albums.DisplayMember = "Title";
                foreach (var album in artist.Albums)
                {
                    Albums.Items.Add(album);
                }
                Songs.Items.Clear();
            }
        }

        private void Albums_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Albums.SelectedItem is Album album)
            {
                Songs.Items.Clear();
                Songs.DisplayMember = "Display";
                foreach (var song in album.Songs)
                {
                    Songs.Items.Add(song);
                }
            }
        }

        private void Songs_SelectedIndexChanged(object sender, EventArgs e)
        {
            Song_SelectedIndexChanged(sender, e);
        }

        private void addAlbum_Click(object sender, EventArgs e)
        {
            if (Albums.SelectedItem is Album album && Playlists.SelectedItem is Playlist myPlaylist)
            {
                foreach (var song in album.Songs)
                {
                    if (myPlaylist.GetSongs().Contains(song))
                    {
                        var result = MessageBox.Show(
                            $"\"{song.Title}\" staat al in de playlist. Toch toevoegen?",
                            "Dubbel nummer",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.No)
                        {
                            continue;
                        }
                    }
                    myPlaylist.AddSong(song);
                }
                ShowPlaylistSongs(myPlaylist);
            }
        }
    }
}
