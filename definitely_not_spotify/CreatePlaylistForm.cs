using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace definitely_not_spotify
{
    public partial class CreatePlaylistForm : Form
    {
        private TextBox txtName;
        private Button btnOk;
        private Button btnCancel;

        public string PlaylistName => txtName.Text;

        public CreatePlaylistForm()
        {
            Text = "Nieuwe playlist";
            Width = 300;
            Height = 150;
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;

            var lbl = new Label { Text = "Naam van de playlist:", Left = 10, Top = 15, Width = 260 };
            txtName = new TextBox { Left = 10, Top = 40, Width = 260 };
            btnOk = new Button { Text = "OK", Left = 110, Top = 75, Width = 75, DialogResult = DialogResult.OK };
            btnCancel = new Button { Text = "Annuleren", Left = 195, Top = 75, Width = 75, DialogResult = DialogResult.Cancel };

            AcceptButton = btnOk;
            CancelButton = btnCancel;

            Controls.Add(lbl);
            Controls.Add(txtName);
            Controls.Add(btnOk);
            Controls.Add(btnCancel);
        }
    }
}
