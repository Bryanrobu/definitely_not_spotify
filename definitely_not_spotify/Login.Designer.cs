namespace definitely_not_spotify
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            userList = new ListBox();
            usernameBox = new TextBox();
            create_user = new Button();
            log_in = new Button();
            SuspendLayout();
            // 
            // userList
            // 
            userList.FormattingEnabled = true;
            userList.Location = new Point(431, 178);
            userList.Name = "userList";
            userList.Size = new Size(120, 94);
            userList.TabIndex = 0;
            // 
            // usernameBox
            // 
            usernameBox.Location = new Point(249, 178);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(100, 23);
            usernameBox.TabIndex = 1;
            // 
            // create_user
            // 
            create_user.Location = new Point(261, 207);
            create_user.Name = "create_user";
            create_user.Size = new Size(75, 23);
            create_user.TabIndex = 2;
            create_user.Text = "Create User";
            create_user.UseVisualStyleBackColor = true;
            create_user.Click += create_user_Click;
            // 
            // log_in
            // 
            log_in.Location = new Point(454, 278);
            log_in.Name = "log_in";
            log_in.Size = new Size(75, 23);
            log_in.TabIndex = 3;
            log_in.Text = "Log in";
            log_in.UseVisualStyleBackColor = true;
            log_in.Click += log_in_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(log_in);
            Controls.Add(create_user);
            Controls.Add(usernameBox);
            Controls.Add(userList);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox userList;
        private TextBox usernameBox;
        private Button create_user;
        private Button log_in;
    }
}