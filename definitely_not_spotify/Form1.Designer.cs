namespace definitely_not_spotify
{
    partial class Form1
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
            button3.Text = "Return";
            button3.UseVisualStyleBackColor = true;
            button3.Click += return_Click;
            // 
            // Playlists
            // 
            Playlists.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            Playlists.FormattingEnabled = true;
            Playlists.Location = new Point(0, 15);
            Playlists.Name = "Playlists";
            Playlists.Size = new Size(137, 364);
            Playlists.TabIndex = 3;
            Playlists.SelectedIndexChanged += Playlists_SelectedIndexChanged;
            // 
            // Numbers
            // 
            Numbers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            Numbers.FormattingEnabled = true;
            Numbers.Location = new Point(143, 15);
            Numbers.Name = "Numbers";
            Numbers.Size = new Size(143, 364);
            Numbers.TabIndex = 4;
            // 
            // Users
            // 
            Users.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            Users.FormattingEnabled = true;
            Users.Location = new Point(681, 12);
            Users.Name = "Users";
            Users.Size = new Size(120, 364);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(nowPlaying);
            Controls.Add(Discover);
            Controls.Add(search);
            Controls.Add(Users);
            Controls.Add(Numbers);
            Controls.Add(Playlists);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
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
    }
}
