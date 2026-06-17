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
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom;
            button1.AutoSize = true;
            button1.Location = new Point(358, 393);
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
            button2.Location = new Point(473, 393);
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
            button3.Location = new Point(243, 393);
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
            Users.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            Users.FormattingEnabled = true;
            Users.Location = new Point(681, 44);
            Users.Name = "Users";
            Users.Size = new Size(120, 334);
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
            Discover.Size = new Size(383, 334);
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
            currentUser.Location = new Point(718, 393);
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
            label3.Location = new Point(681, 18);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 12;
            label3.Text = "Users";
            // 
            // logout
            // 
            logout.Location = new Point(718, 415);
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
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
