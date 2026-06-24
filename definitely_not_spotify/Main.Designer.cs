namespace definitely_not_spotify
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            Playlists = new ListBox();
            Numbers = new ListBox();
            Users = new ListBox();
            search = new TextBox();
            Discover = new ListBox();
            nowPlaying = new TextBox();
            currentUser = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            logout = new Button();
            add_playlist = new Button();
            delete_playlist = new Button();
            addSong = new Button();
            removeSong = new Button();
            stopButton = new Button();
            artists = new ListBox();
            label4 = new Label();
            Albums = new ListBox();
            label5 = new Label();
            Songs = new ListBox();
            label6 = new Label();
            FriendRequests = new ListBox();
            label7 = new Label();
            AddFriend = new Button();
            AcceptFriend = new Button();
            DeclineFriend = new Button();
            FriendsList = new ListBox();
            label8 = new Label();
            FriendPlaylists = new ListBox();
            label9 = new Label();
            FriendSongs = new ListBox();
            label10 = new Label();
            addFriendSong = new Button();
            addFriendPlaylist = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom;
            button1.AutoSize = true;
            button1.Location = new Point(430, 398);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(109, 45);
            button1.TabIndex = 0;
            button1.Text = "Play/pause";
            button1.UseVisualStyleBackColor = true;
            button1.Click += play_pause_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom;
            button2.AutoSize = true;
            button2.Location = new Point(545, 400);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(109, 45);
            button2.TabIndex = 1;
            button2.Text = "Skip";
            button2.UseVisualStyleBackColor = true;
            button2.Click += skip_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom;
            button3.AutoSize = true;
            button3.Location = new Point(315, 398);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(109, 45);
            button3.TabIndex = 2;
            button3.Text = "Previous";
            button3.UseVisualStyleBackColor = true;
            button3.Click += return_Click;
            // 
            // Playlists
            // 
            Playlists.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            Playlists.FormattingEnabled = true;
            Playlists.Location = new Point(0, 45);
            Playlists.Name = "Playlists";
            Playlists.Size = new Size(137, 304);
            Playlists.TabIndex = 3;
            Playlists.SelectedIndexChanged += Playlists_SelectedIndexChanged;
            // 
            // Numbers
            // 
            Numbers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            Numbers.FormattingEnabled = true;
            Numbers.Location = new Point(143, 45);
            Numbers.Name = "Numbers";
            Numbers.Size = new Size(143, 304);
            Numbers.TabIndex = 4;
            // 
            // Users
            // 
            Users.Anchor = AnchorStyles.Left;
            Users.FormattingEnabled = true;
            Users.Location = new Point(1156, 45);
            Users.Name = "Users";
            Users.Size = new Size(120, 154);
            Users.TabIndex = 5;
            Users.SelectedIndexChanged += Users_SelectedIndexChanged;
            // 
            // search
            // 
            search.Location = new Point(292, 15);
            search.Name = "search";
            search.PlaceholderText = "Input search ";
            search.Size = new Size(383, 23);
            search.TabIndex = 6;
            search.KeyUp += search_KeyUp;
            // 
            // Discover
            // 
            Discover.FormattingEnabled = true;
            Discover.Location = new Point(292, 44);
            Discover.Name = "Discover";
            Discover.Size = new Size(383, 304);
            Discover.TabIndex = 7;
            // 
            // nowPlaying
            // 
            nowPlaying.BackColor = SystemColors.Window;
            nowPlaying.Enabled = false;
            nowPlaying.Location = new Point(12, 393);
            nowPlaying.Multiline = true;
            nowPlaying.Name = "nowPlaying";
            nowPlaying.ReadOnly = true;
            nowPlaying.Size = new Size(180, 45);
            nowPlaying.TabIndex = 8;
            // 
            // currentUser
            // 
            currentUser.AutoSize = true;
            currentUser.Location = new Point(1156, 393);
            currentUser.Name = "currentUser";
            currentUser.Size = new Size(70, 15);
            currentUser.TabIndex = 9;
            currentUser.Text = "current user";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 27);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 10;
            label1.Text = "Playlists";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(143, 27);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 11;
            label2.Text = "Numbers";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1156, 23);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 12;
            label3.Text = "Users";
            // 
            // logout
            // 
            logout.Location = new Point(1156, 415);
            logout.Name = "logout";
            logout.Size = new Size(75, 23);
            logout.TabIndex = 13;
            logout.Text = "Log out";
            logout.UseVisualStyleBackColor = true;
            logout.Click += logout_Click;
            // 
            // add_playlist
            // 
            add_playlist.Location = new Point(0, 355);
            add_playlist.Name = "add_playlist";
            add_playlist.Size = new Size(137, 23);
            add_playlist.TabIndex = 14;
            add_playlist.Text = "Add playlist";
            add_playlist.UseVisualStyleBackColor = true;
            add_playlist.Click += add_playlist_Click;
            // 
            // delete_playlist
            // 
            delete_playlist.Location = new Point(143, 355);
            delete_playlist.Name = "delete_playlist";
            delete_playlist.Size = new Size(143, 23);
            delete_playlist.TabIndex = 15;
            delete_playlist.Text = "Delete playlist";
            delete_playlist.UseVisualStyleBackColor = true;
            delete_playlist.Click += delete_playlist_Click;
            // 
            // addSong
            // 
            addSong.Location = new Point(292, 354);
            addSong.Name = "addSong";
            addSong.Size = new Size(143, 23);
            addSong.TabIndex = 16;
            addSong.Text = "Add to playlist";
            addSong.UseVisualStyleBackColor = true;
            addSong.Click += addSong_Click;
            // 
            // removeSong
            // 
            removeSong.Location = new Point(439, 355);
            removeSong.Name = "removeSong";
            removeSong.Size = new Size(143, 23);
            removeSong.TabIndex = 17;
            removeSong.Text = "Remove from playlist";
            removeSong.UseVisualStyleBackColor = true;
            removeSong.Click += removeSong_Click;
            // 
            // stopButton
            // 
            stopButton.Location = new Point(660, 400);
            stopButton.Margin = new Padding(3, 2, 3, 2);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(62, 41);
            stopButton.TabIndex = 18;
            stopButton.Text = "Stop";
            stopButton.UseVisualStyleBackColor = true;
            stopButton.Click += stopButton_Click;
            // 
            // artists
            // 
            artists.FormattingEnabled = true;
            artists.Location = new Point(681, 45);
            artists.Name = "artists";
            artists.Size = new Size(114, 304);
            artists.TabIndex = 19;
            artists.SelectedIndexChanged += Artists_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(681, 23);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 20;
            label4.Text = "Artists";
            // 
            // Albums
            // 
            Albums.FormattingEnabled = true;
            Albums.Location = new Point(801, 44);
            Albums.Name = "Albums";
            Albums.Size = new Size(114, 304);
            Albums.TabIndex = 21;
            Albums.SelectedIndexChanged += Albums_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(801, 23);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 22;
            label5.Text = "Albums";
            // 
            // Songs
            // 
            Songs.FormattingEnabled = true;
            Songs.Location = new Point(921, 44);
            Songs.Name = "Songs";
            Songs.Size = new Size(229, 304);
            Songs.TabIndex = 23;
            Songs.SelectedIndexChanged += Songs_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(921, 23);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 24;
            label6.Text = "Numbers";
            // 
            // FriendRequests
            // 
            FriendRequests.Anchor = AnchorStyles.Left;
            FriendRequests.FormattingEnabled = true;
            FriendRequests.Location = new Point(1156, 225);
            FriendRequests.Name = "FriendRequests";
            FriendRequests.Size = new Size(120, 124);
            FriendRequests.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1156, 207);
            label7.Name = "label7";
            label7.Size = new Size(87, 15);
            label7.TabIndex = 26;
            label7.Text = "Friend requests";
            // 
            // AddFriend
            // 
            AddFriend.Location = new Point(1156, 354);
            AddFriend.Name = "AddFriend";
            AddFriend.Size = new Size(92, 23);
            AddFriend.TabIndex = 27;
            AddFriend.Text = "Add friend";
            AddFriend.UseVisualStyleBackColor = true;
            AddFriend.Click += AddFriend_Click;
            // 
            // AcceptFriend
            // 
            AcceptFriend.Location = new Point(1254, 354);
            AcceptFriend.Name = "AcceptFriend";
            AcceptFriend.Size = new Size(92, 23);
            AcceptFriend.TabIndex = 28;
            AcceptFriend.Text = "Accept friend";
            AcceptFriend.UseVisualStyleBackColor = true;
            AcceptFriend.Click += AcceptFriend_Click;
            // 
            // DeclineFriend
            // 
            DeclineFriend.Location = new Point(1254, 383);
            DeclineFriend.Name = "DeclineFriend";
            DeclineFriend.Size = new Size(92, 23);
            DeclineFriend.TabIndex = 29;
            DeclineFriend.Text = "Decline friend";
            DeclineFriend.UseVisualStyleBackColor = true;
            DeclineFriend.Click += DeclineFriend_Click;
            // 
            // FriendsList
            // 
            FriendsList.Anchor = AnchorStyles.Left;
            FriendsList.FormattingEnabled = true;
            FriendsList.Location = new Point(1295, 45);
            FriendsList.Margin = new Padding(3, 2, 3, 2);
            FriendsList.Name = "FriendsList";
            FriendsList.Size = new Size(106, 154);
            FriendsList.TabIndex = 30;
            FriendsList.SelectedIndexChanged += FriendsList_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1295, 23);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 31;
            label8.Text = "Friends";
            // 
            // FriendPlaylists
            // 
            FriendPlaylists.Anchor = AnchorStyles.Left;
            FriendPlaylists.FormattingEnabled = true;
            FriendPlaylists.Location = new Point(1295, 225);
            FriendPlaylists.Margin = new Padding(3, 2, 3, 2);
            FriendPlaylists.Name = "FriendPlaylists";
            FriendPlaylists.Size = new Size(106, 124);
            FriendPlaylists.TabIndex = 32;
            FriendPlaylists.SelectedIndexChanged += FriendPlaylists_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1295, 207);
            label9.Name = "label9";
            label9.Size = new Size(90, 15);
            label9.TabIndex = 33;
            label9.Text = "Friends Playlists";
            // 
            // FriendSongs
            // 
            FriendSongs.Anchor = AnchorStyles.Left;
            FriendSongs.FormattingEnabled = true;
            FriendSongs.Location = new Point(1407, 45);
            FriendSongs.Margin = new Padding(3, 2, 3, 2);
            FriendSongs.Name = "FriendSongs";
            FriendSongs.Size = new Size(106, 304);
            FriendSongs.TabIndex = 34;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1407, 23);
            label10.Name = "label10";
            label10.Size = new Size(80, 15);
            label10.TabIndex = 35;
            label10.Text = "Friends Songs";
            // 
            // addFriendSong
            // 
            addFriendSong.Location = new Point(1398, 353);
            addFriendSong.Margin = new Padding(3, 2, 3, 2);
            addFriendSong.Name = "addFriendSong";
            addFriendSong.Size = new Size(139, 24);
            addFriendSong.TabIndex = 36;
            addFriendSong.Text = "Add song to playlist";
            addFriendSong.UseVisualStyleBackColor = true;
            addFriendSong.Click += addFriendSong_Click;
            // 
            // addFriendPlaylist
            // 
            addFriendPlaylist.Location = new Point(1398, 381);
            addFriendPlaylist.Margin = new Padding(3, 2, 3, 2);
            addFriendPlaylist.Name = "addFriendPlaylist";
            addFriendPlaylist.Size = new Size(139, 26);
            addFriendPlaylist.TabIndex = 37;
            addFriendPlaylist.Text = "Add playlist to playlist";
            addFriendPlaylist.UseVisualStyleBackColor = true;
            addFriendPlaylist.Click += addFriendPlaylist_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1539, 441);
            Controls.Add(addFriendPlaylist);
            Controls.Add(addFriendSong);
            Controls.Add(label10);
            Controls.Add(FriendSongs);
            Controls.Add(label9);
            Controls.Add(FriendPlaylists);
            Controls.Add(label8);
            Controls.Add(FriendsList);
            Controls.Add(DeclineFriend);
            Controls.Add(AcceptFriend);
            Controls.Add(AddFriend);
            Controls.Add(label7);
            Controls.Add(FriendRequests);
            Controls.Add(label6);
            Controls.Add(Songs);
            Controls.Add(label5);
            Controls.Add(Albums);
            Controls.Add(label4);
            Controls.Add(artists);
            Controls.Add(stopButton);
            Controls.Add(removeSong);
            Controls.Add(addSong);
            Controls.Add(delete_playlist);
            Controls.Add(add_playlist);
            Controls.Add(logout);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(currentUser);
            Controls.Add(nowPlaying);
            Controls.Add(Discover);
            Controls.Add(search);
            Controls.Add(Users);
            Controls.Add(Numbers);
            Controls.Add(Playlists);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Main";
            Text = "Main";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private ListBox Playlists;
        private ListBox Numbers;
        private ListBox Users;
        private TextBox search;
        private ListBox Discover;
        private TextBox nowPlaying;
        private Label currentUser;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button logout;
        private Button add_playlist;
        private Button delete_playlist;
        private Button addSong;
        private Button removeSong;
        private Button stopButton;
        private ListBox artists;
        private Label label4;
        private ListBox Albums;
        private Label label5;
        private ListBox Songs;
        private Label label6;
        private ListBox FriendRequests;
        private Label label7;
        private Button AddFriend;
        private Button AcceptFriend;
        private Button DeclineFriend;
        private ListBox FriendsList;
        private Label label8;
        private ListBox FriendPlaylists;
        private Label label9;
        private ListBox FriendSongs;
        private Label label10;
        private Button addFriendSong;
        private Button addFriendPlaylist;
    }
}
