namespace Book_Library.Books
{
    partial class frmAdminsMainScreen
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Add");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Update");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Delete");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Books");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Admins");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Users");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("People");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Logins");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminsMainScreen));
            this.flpScreen = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.tvSubSideMenu = new System.Windows.Forms.TreeView();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnSignUp = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.tvMainSideMenu = new System.Windows.Forms.TreeView();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.flpScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flpScreen
            // 
            this.flpScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpScreen.AutoScroll = true;
            this.flpScreen.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.flpScreen.BackgroundImage = global::Book_Library.Properties.Resources.BooksIcon;
            this.flpScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flpScreen.Controls.Add(this.dgvTable);
            this.flpScreen.Controls.Add(this.tvSubSideMenu);
            this.flpScreen.Location = new System.Drawing.Point(202, 124);
            this.flpScreen.Margin = new System.Windows.Forms.Padding(4);
            this.flpScreen.Name = "flpScreen";
            this.flpScreen.Size = new System.Drawing.Size(1374, 643);
            this.flpScreen.TabIndex = 0;
            // 
            // dgvTable
            // 
            this.dgvTable.AllowUserToAddRows = false;
            this.dgvTable.AllowUserToDeleteRows = false;
            this.dgvTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Location = new System.Drawing.Point(3, 3);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.ReadOnly = true;
            this.dgvTable.RowHeadersWidth = 62;
            this.dgvTable.RowTemplate.Height = 29;
            this.dgvTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTable.Size = new System.Drawing.Size(1035, 165);
            this.dgvTable.TabIndex = 6;
            this.dgvTable.Visible = false;
            // 
            // tvSubSideMenu
            // 
            this.tvSubSideMenu.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvSubSideMenu.FullRowSelect = true;
            this.tvSubSideMenu.Indent = 5;
            this.tvSubSideMenu.ItemHeight = 45;
            this.tvSubSideMenu.Location = new System.Drawing.Point(1045, 4);
            this.tvSubSideMenu.Margin = new System.Windows.Forms.Padding(4);
            this.tvSubSideMenu.Name = "tvSubSideMenu";
            treeNode1.Name = "Add";
            treeNode1.Text = "Add";
            treeNode2.Name = "Update";
            treeNode2.Text = "Update";
            treeNode3.Name = "Delete";
            treeNode3.Text = "Delete";
            this.tvSubSideMenu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.tvSubSideMenu.ShowLines = false;
            this.tvSubSideMenu.Size = new System.Drawing.Size(189, 641);
            this.tvSubSideMenu.TabIndex = 8;
            this.tvSubSideMenu.Visible = false;
            this.tvSubSideMenu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvSubSideMenu_AfterSelect);
            this.tvSubSideMenu.Click += new System.EventHandler(this.tvSubSideMenu_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUsername.Location = new System.Drawing.Point(171, 42);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(232, 39);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Abdulrahman";
            // 
            // btnSignUp
            // 
            this.btnSignUp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSignUp.BorderRadius = 20;
            this.btnSignUp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSignUp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSignUp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSignUp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSignUp.FillColor = System.Drawing.Color.MediumBlue;
            this.btnSignUp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(1343, 4);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(4);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(233, 66);
            this.btnSignUp.TabIndex = 4;
            this.btnSignUp.Text = "Logout";
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 20;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(1192, 18);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(87, 66);
            this.guna2Button2.TabIndex = 6;
            // 
            // tvMainSideMenu
            // 
            this.tvMainSideMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvMainSideMenu.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvMainSideMenu.FullRowSelect = true;
            this.tvMainSideMenu.Indent = 5;
            this.tvMainSideMenu.ItemHeight = 45;
            this.tvMainSideMenu.Location = new System.Drawing.Point(5, 123);
            this.tvMainSideMenu.Margin = new System.Windows.Forms.Padding(4);
            this.tvMainSideMenu.Name = "tvMainSideMenu";
            treeNode4.Checked = true;
            treeNode4.Name = "Books";
            treeNode4.Text = "Books";
            treeNode5.Name = "Admins";
            treeNode5.Text = "Admins";
            treeNode6.Name = "Users";
            treeNode6.Text = "Users";
            treeNode7.Name = "People";
            treeNode7.Text = "People";
            treeNode8.Name = "Logins";
            treeNode8.Text = "Logins";
            this.tvMainSideMenu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
            this.tvMainSideMenu.ShowLines = false;
            this.tvMainSideMenu.Size = new System.Drawing.Size(189, 641);
            this.tvMainSideMenu.TabIndex = 7;
            this.tvMainSideMenu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvSideMenu_AfterSelect);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::Book_Library.Properties.Resources.Unknwonperson_man;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(18, 4);
            this.guna2CirclePictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(138, 111);
            this.guna2CirclePictureBox1.TabIndex = 2;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // frmAdminsMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1578, 772);
            this.Controls.Add(this.tvMainSideMenu);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.flpScreen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAdminsMainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Screen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAdminsMainScreen_FormClosed);
            this.Load += new System.EventHandler(this.frmMainScreen_Load);
            this.flpScreen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpScreen;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label lblUsername;
        private Guna.UI2.WinForms.Guna2Button btnSignUp;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.TreeView tvMainSideMenu;
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.TreeView tvSubSideMenu;
    }
}