using definitely_not_spotify.Models;
using System.Collections;
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
            FillTargetPlaylists();
        }

        private void Fill(ListBox box, IEnumerable items, string displayMember = null)
        {
            box.Items.Clear();
            box.DisplayMember = displayMember;
            foreach (var item in items) box.Items.Add(item);
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
                if (list != FriendSongs) FriendSongs.ClearSelected();
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
            nowPlaying.Text = status + ": " + currentSong.Title + Environment.NewLine + currentSong.Artists + " - " + currentSong.Genre;
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
            Fill(Numbers, playlist.Songs, "Display");
        }

        private void Users_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void search_KeyUp(object sender, KeyEventArgs e)
        {
            Fill(Discover, client.Search(search.Text), "Display");
        }
        private void FillUsers()
        {
            Fill(Users, client.Users.Where(u => u.Username != user.Username), "Username");
        }

        private void FillDiscover()
        {
            Fill(Discover, client.Songs, "Display");
        }

        private void FillPlaylists()
        {
            Fill(Playlists, user.Playlists);
        }

        private void FillArtists()
        {
            Fill(artists, client.Artists, "Name");
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
            if (selectedSong != null && Playlists.SelectedItem is Playlist myPlaylist)
                AddSongsToPlaylist(new[] { selectedSong }, myPlaylist);
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
            Fill(FriendRequests, user.FriendRequests, "Username");
        }

        private void FillFriends()
        {
            Fill(FriendsList, user.Friends, "Username");
        }

        private void FriendsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            FriendSongs.Items.Clear();
            if (FriendsList.SelectedItem is User friend)
                Fill(FriendPlaylists, friend.Playlists);
            else
                FriendPlaylists.Items.Clear();
        }

        private void FriendPlaylists_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FriendPlaylists.SelectedItem is Playlist playlist)
                Fill(FriendSongs, playlist.Songs, "Display");
            else
                FriendSongs.Items.Clear();
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

        private void addFriendPlaylist_Click(object sender, EventArgs e)
        {
            if (FriendPlaylists.SelectedItem is Playlist friendPlaylist && Playlists.SelectedItem is Playlist myPlaylist)
                AddSongsToPlaylist(friendPlaylist.Songs, myPlaylist);
        }

        private void addFriendSong_Click(object sender, EventArgs e)
        {
            if (FriendSongs.SelectedItem is Song song && Playlists.SelectedItem is Playlist myPlaylist)
                AddSongsToPlaylist(new[] { song }, myPlaylist);
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

        private void addAlbum_Click(object sender, EventArgs e)
        {
            if (Albums.SelectedItem is Album album && Playlists.SelectedItem is Playlist myPlaylist)
                AddSongsToPlaylist(album.Songs, myPlaylist);
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

        private void AddSongsToPlaylist(IEnumerable<Song> songs, Playlist target)
        {
            foreach (var song in songs)
            {
                if (target.Songs.Contains(song))
                {
                    var result = MessageBox.Show(
                        $"\"{song.Title}\" staat al in de playlist. Toch toevoegen?",
                        "Dubbel nummer",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.No) continue;
                }
                target.AddSong(song);
            }
            ShowPlaylistSongs(target);
        }

        private void FillTargetPlaylists()
        {
            targetPlaylist.Items.Clear();
            foreach (var p in user.Playlists)
                targetPlaylist.Items.Add(p);
        }

        private void addOwnPlaylist_Click(object sender, EventArgs e)
        {
            if (Playlists.SelectedItem is Playlist source
            && targetPlaylist.SelectedItem is Playlist target
            && source != target)
            {
                AddSongsToPlaylist(target.Songs, source);
            }
        }

        private void removeFriend_Click(object sender, EventArgs e)
        {
            if (FriendsList.SelectedItem is User from)
            {
                client.RemoveFriend(from);
                FillFriends();
            }
        }
    }
}
