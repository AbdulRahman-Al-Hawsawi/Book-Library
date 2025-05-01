namespace Book_Library.Users
{
    partial class frmAddUpdateUserInfo
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.chkIsAdmin = new System.Windows.Forms.CheckBox();
            this.chkAddBooks = new System.Windows.Forms.CheckBox();
            this.chkDeleteBook = new System.Windows.Forms.CheckBox();
            this.chkUpdateUsers = new System.Windows.Forms.CheckBox();
            this.chkAddUsers = new System.Windows.Forms.CheckBox();
            this.chkDeleteUsers = new System.Windows.Forms.CheckBox();
            this.chkReadUsers = new System.Windows.Forms.CheckBox();
            this.chkFullPermissions = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chkUpdateBooks = new System.Windows.Forms.CheckBox();
            this.gbPermissions = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.pb = new System.Windows.Forms.PictureBox();
            this.gbPermissions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(184, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Username";
            // 
            // tbUsername
            // 
            this.tbUsername.BorderRadius = 20;
            this.tbUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUsername.DefaultText = "";
            this.tbUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbUsername.Location = new System.Drawing.Point(55, 148);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.PlaceholderText = "";
            this.tbUsername.SelectedText = "";
            this.tbUsername.Size = new System.Drawing.Size(358, 53);
            this.tbUsername.TabIndex = 5;
            this.tbUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbUsername.TextChanged += new System.EventHandler(this.tbUsername_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 224);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Password";
            // 
            // tbPassword
            // 
            this.tbPassword.BorderRadius = 20;
            this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassword.DefaultText = "";
            this.tbPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPassword.Location = new System.Drawing.Point(55, 255);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PlaceholderText = "";
            this.tbPassword.SelectedText = "";
            this.tbPassword.Size = new System.Drawing.Size(358, 53);
            this.tbPassword.TabIndex = 7;
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(150, 339);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Confirm Password";
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.BorderRadius = 20;
            this.tbConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbConfirmPassword.DefaultText = "";
            this.tbConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbConfirmPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbConfirmPassword.Location = new System.Drawing.Point(55, 370);
            this.tbConfirmPassword.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.PlaceholderText = "";
            this.tbConfirmPassword.SelectedText = "";
            this.tbConfirmPassword.Size = new System.Drawing.Size(358, 53);
            this.tbConfirmPassword.TabIndex = 9;
            this.tbConfirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbConfirmPassword.TextChanged += new System.EventHandler(this.tbConfirmPassword_TextChanged);
            // 
            // chkIsAdmin
            // 
            this.chkIsAdmin.AutoSize = true;
            this.chkIsAdmin.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIsAdmin.Location = new System.Drawing.Point(64, 452);
            this.chkIsAdmin.Name = "chkIsAdmin";
            this.chkIsAdmin.Size = new System.Drawing.Size(151, 38);
            this.chkIsAdmin.TabIndex = 11;
            this.chkIsAdmin.Text = "Is Admin";
            this.chkIsAdmin.UseVisualStyleBackColor = true;
            this.chkIsAdmin.CheckedChanged += new System.EventHandler(this.chbIsAdmin_CheckedChanged);
            // 
            // chkAddBooks
            // 
            this.chkAddBooks.AutoSize = true;
            this.chkAddBooks.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAddBooks.Location = new System.Drawing.Point(28, 85);
            this.chkAddBooks.Name = "chkAddBooks";
            this.chkAddBooks.Size = new System.Drawing.Size(171, 38);
            this.chkAddBooks.TabIndex = 12;
            this.chkAddBooks.Text = "Add Books";
            this.chkAddBooks.UseVisualStyleBackColor = true;
            this.chkAddBooks.CheckedChanged += new System.EventHandler(this.chkAddBooks_CheckedChanged);
            // 
            // chkDeleteBook
            // 
            this.chkDeleteBook.AutoSize = true;
            this.chkDeleteBook.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDeleteBook.Location = new System.Drawing.Point(28, 191);
            this.chkDeleteBook.Name = "chkDeleteBook";
            this.chkDeleteBook.Size = new System.Drawing.Size(203, 38);
            this.chkDeleteBook.TabIndex = 13;
            this.chkDeleteBook.Text = "Delete Books";
            this.chkDeleteBook.UseVisualStyleBackColor = true;
            // 
            // chkUpdateUsers
            // 
            this.chkUpdateUsers.AutoSize = true;
            this.chkUpdateUsers.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUpdateUsers.Location = new System.Drawing.Point(301, 191);
            this.chkUpdateUsers.Name = "chkUpdateUsers";
            this.chkUpdateUsers.Size = new System.Drawing.Size(206, 38);
            this.chkUpdateUsers.TabIndex = 15;
            this.chkUpdateUsers.Text = "Update Users";
            this.chkUpdateUsers.UseVisualStyleBackColor = true;
            // 
            // chkAddUsers
            // 
            this.chkAddUsers.AutoSize = true;
            this.chkAddUsers.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAddUsers.Location = new System.Drawing.Point(301, 138);
            this.chkAddUsers.Name = "chkAddUsers";
            this.chkAddUsers.Size = new System.Drawing.Size(166, 38);
            this.chkAddUsers.TabIndex = 16;
            this.chkAddUsers.Text = "Add Users";
            this.chkAddUsers.UseVisualStyleBackColor = true;
            // 
            // chkDeleteUsers
            // 
            this.chkDeleteUsers.AutoSize = true;
            this.chkDeleteUsers.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDeleteUsers.Location = new System.Drawing.Point(301, 244);
            this.chkDeleteUsers.Name = "chkDeleteUsers";
            this.chkDeleteUsers.Size = new System.Drawing.Size(198, 38);
            this.chkDeleteUsers.TabIndex = 17;
            this.chkDeleteUsers.Text = "Delete Users";
            this.chkDeleteUsers.UseVisualStyleBackColor = true;
            // 
            // chkReadUsers
            // 
            this.chkReadUsers.AutoSize = true;
            this.chkReadUsers.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkReadUsers.Location = new System.Drawing.Point(301, 85);
            this.chkReadUsers.Name = "chkReadUsers";
            this.chkReadUsers.Size = new System.Drawing.Size(181, 38);
            this.chkReadUsers.TabIndex = 18;
            this.chkReadUsers.Text = "Read Users";
            this.chkReadUsers.UseVisualStyleBackColor = true;
            // 
            // chkFullPermissions
            // 
            this.chkFullPermissions.AutoSize = true;
            this.chkFullPermissions.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFullPermissions.Location = new System.Drawing.Point(28, 244);
            this.chkFullPermissions.Name = "chkFullPermissions";
            this.chkFullPermissions.Size = new System.Drawing.Size(239, 38);
            this.chkFullPermissions.TabIndex = 19;
            this.chkFullPermissions.Text = "Full Permissions";
            this.chkFullPermissions.UseVisualStyleBackColor = true;
            this.chkFullPermissions.CheckedChanged += new System.EventHandler(this.chkFullPermissions_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(62, 39);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 39);
            this.label4.TabIndex = 20;
            this.label4.Text = "Books";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(341, 39);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 39);
            this.label5.TabIndex = 21;
            this.label5.Text = "Users";
            // 
            // chkUpdateBooks
            // 
            this.chkUpdateBooks.AutoSize = true;
            this.chkUpdateBooks.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUpdateBooks.Location = new System.Drawing.Point(28, 138);
            this.chkUpdateBooks.Name = "chkUpdateBooks";
            this.chkUpdateBooks.Size = new System.Drawing.Size(211, 38);
            this.chkUpdateBooks.TabIndex = 23;
            this.chkUpdateBooks.Text = "Update Books";
            this.chkUpdateBooks.UseVisualStyleBackColor = true;
            // 
            // gbPermissions
            // 
            this.gbPermissions.BackColor = System.Drawing.SystemColors.Info;
            this.gbPermissions.Controls.Add(this.chkUpdateBooks);
            this.gbPermissions.Controls.Add(this.chkAddBooks);
            this.gbPermissions.Controls.Add(this.label5);
            this.gbPermissions.Controls.Add(this.chkReadUsers);
            this.gbPermissions.Controls.Add(this.chkDeleteBook);
            this.gbPermissions.Controls.Add(this.chkDeleteUsers);
            this.gbPermissions.Controls.Add(this.chkFullPermissions);
            this.gbPermissions.Controls.Add(this.chkAddUsers);
            this.gbPermissions.Controls.Add(this.label4);
            this.gbPermissions.Controls.Add(this.chkUpdateUsers);
            this.gbPermissions.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPermissions.Location = new System.Drawing.Point(574, 117);
            this.gbPermissions.Name = "gbPermissions";
            this.gbPermissions.Size = new System.Drawing.Size(519, 348);
            this.gbPermissions.TabIndex = 24;
            this.gbPermissions.TabStop = false;
            this.gbPermissions.Text = "Permissions";
            this.gbPermissions.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 20;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.MediumBlue;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(441, 481);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(270, 66);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pb
            // 
            this.pb.Image = global::Book_Library.Properties.Resources.BooksIcon;
            this.pb.Location = new System.Drawing.Point(441, 48);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(664, 488);
            this.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb.TabIndex = 26;
            this.pb.TabStop = false;
            // 
            // frmAddUpdateUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 578);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbPermissions);
            this.Controls.Add(this.chkIsAdmin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbConfirmPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.pb);
            this.Name = "frmAddUpdateUserInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Info";
            this.Load += new System.EventHandler(this.frmAddUpdateUserInfo_Load);
            this.gbPermissions.ResumeLayout(false);
            this.gbPermissions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox tbUsername;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox tbPassword;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox tbConfirmPassword;
        private System.Windows.Forms.CheckBox chkIsAdmin;
        private System.Windows.Forms.CheckBox chkAddBooks;
        private System.Windows.Forms.CheckBox chkDeleteBook;
        private System.Windows.Forms.CheckBox chkUpdateUsers;
        private System.Windows.Forms.CheckBox chkAddUsers;
        private System.Windows.Forms.CheckBox chkDeleteUsers;
        private System.Windows.Forms.CheckBox chkReadUsers;
        private System.Windows.Forms.CheckBox chkFullPermissions;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkUpdateBooks;
        private System.Windows.Forms.GroupBox gbPermissions;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.PictureBox pb;
    }
}