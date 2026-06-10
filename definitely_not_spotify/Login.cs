using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using definitely_not_spotify.Models;

namespace definitely_not_spotify
{
    public partial class Login : Form
    {
        private Client client;

        public Login(Client client)
        {
            InitializeComponent();
            this.client = client;
            userList.DisplayMember = "Username";
            RefreshUserList();
        }
        private void RefreshUserList()
        {
            userList.Items.Clear();
            foreach (var user in client.Users)
            {
                userList.Items.Add(user);
            }
        }

        private void create_user_Click(object sender, EventArgs e)
        {
            client.CreateUser(usernameBox.Text);
            usernameBox.Clear();
            RefreshUserList();
        }

        private void log_in_Click(object sender, EventArgs e)
        {
            if (userList.SelectedItem is User selected)
            {
                client.Login(selected.Username);
                new Main(client).Show();
                Hide();
            }

        }
    }
}
