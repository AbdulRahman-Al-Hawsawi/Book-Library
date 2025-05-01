namespace Book_Library.Books
{
    partial class frmHomeUserScreen
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
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Books");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("My Books");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Reservations");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Fines");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Metaphors");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHomeUserScreen));
            this.tvNavigationOptions = new System.Windows.Forms.TreeView();
            this.flpScreen = new System.Windows.Forms.FlowLayoutPanel();
            this.lblNoRecord = new System.Windows.Forms.Label();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.cmsReturnBook = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tmsReturnBook = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUsername = new System.Windows.Forms.Label();
            this.imageListIcons = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pbPersonImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.flpScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.cmsReturnBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tvNavigationOptions
            // 
            this.tvNavigationOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvNavigationOptions.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvNavigationOptions.FullRowSelect = true;
            this.tvNavigationOptions.Indent = 5;
            this.tvNavigationOptions.ItemHeight = 45;
            this.tvNavigationOptions.Location = new System.Drawing.Point(2, 153);
            this.tvNavigationOptions.Margin = new System.Windows.Forms.Padding(4);
            this.tvNavigationOptions.Name = "tvNavigationOptions";
            treeNode6.Checked = true;
            treeNode6.Name = "Books";
            treeNode6.Text = "Books";
            treeNode7.Name = "MyBooks";
            treeNode7.Text = "My Books";
            treeNode8.Name = "Reservations";
            treeNode8.Text = "Reservations";
            treeNode9.Name = "Fines";
            treeNode9.Text = "Fines";
            treeNode10.Name = "Metaphors";
            treeNode10.Text = "Metaphors";
            this.tvNavigationOptions.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10});
            this.tvNavigationOptions.ShowLines = false;
            this.tvNavigationOptions.Size = new System.Drawing.Size(209, 641);
            this.tvNavigationOptions.TabIndex = 3;
            this.tvNavigationOptions.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvNavigationOptions_AfterSelect);
            // 
            // flpScreen
            // 
            this.flpScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpScreen.AutoScroll = true;
            this.flpScreen.BackColor = System.Drawing.SystemColors.Info;
            this.flpScreen.Controls.Add(this.lblNoRecord);
            this.flpScreen.Controls.Add(this.dgvTable);
            this.flpScreen.Location = new System.Drawing.Point(211, 153);
            this.flpScreen.Margin = new System.Windows.Forms.Padding(4);
            this.flpScreen.Name = "flpScreen";
            this.flpScreen.Size = new System.Drawing.Size(1345, 643);
            this.flpScreen.TabIndex = 2;
            // 
            // lblNoRecord
            // 
            this.lblNoRecord.AutoSize = true;
            this.lblNoRecord.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoRecord.ForeColor = System.Drawing.Color.Red;
            this.lblNoRecord.Location = new System.Drawing.Point(3, 0);
            this.lblNoRecord.Name = "lblNoRecord";
            this.lblNoRecord.Size = new System.Drawing.Size(215, 39);
            this.lblNoRecord.TabIndex = 6;
            this.lblNoRecord.Text = "lblNoRecord";
            this.lblNoRecord.Visible = false;
            // 
            // dgvTable
            // 
            this.dgvTable.AllowUserToAddRows = false;
            this.dgvTable.AllowUserToDeleteRows = false;
            this.dgvTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Location = new System.Drawing.Point(224, 3);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.ReadOnly = true;
            this.dgvTable.RowHeadersWidth = 62;
            this.dgvTable.RowTemplate.Height = 29;
            this.dgvTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTable.Size = new System.Drawing.Size(1035, 165);
            this.dgvTable.TabIndex = 5;
            this.dgvTable.Visible = false;
            this.dgvTable.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dgvTable_Scroll);
            // 
            // cmsReturnBook
            // 
            this.cmsReturnBook.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsReturnBook.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmsReturnBook});
            this.cmsReturnBook.Name = "cmsBookOptions";
            this.cmsReturnBook.Size = new System.Drawing.Size(221, 42);
            // 
            // tmsReturnBook
            // 
            this.tmsReturnBook.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tmsReturnBook.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tmsReturnBook.Image = ((System.Drawing.Image)(resources.GetObject("tmsReturnBook.Image")));
            this.tmsReturnBook.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tmsReturnBook.Name = "tmsReturnBook";
            this.tmsReturnBook.Size = new System.Drawing.Size(220, 38);
            this.tmsReturnBook.Text = "Return Book";
            this.tmsReturnBook.Click += new System.EventHandler(this.tmsReturnBook_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblUsername.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.Red;
            this.lblUsername.Location = new System.Drawing.Point(187, 59);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(179, 39);
            this.lblUsername.TabIndex = 16;
            this.lblUsername.Text = "Username";
            this.lblUsername.Click += new System.EventHandler(this.lblUsername_Click);
            // 
            // imageListIcons
            // 
            this.imageListIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListIcons.ImageStream")));
            this.imageListIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListIcons.Images.SetKeyName(0, "sign_out.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(749, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 48);
            this.label1.TabIndex = 20;
            this.label1.Text = "Al-Hawsawi Library";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.White;
            this.guna2PictureBox1.BorderRadius = 50;
            this.guna2PictureBox1.Image = global::Book_Library.Properties.Resources.library__1_;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(1179, 10);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(167, 136);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 21;
            this.guna2PictureBox1.TabStop = false;
            // 
            // pbPersonImage
            // 
            this.pbPersonImage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pbPersonImage.BorderRadius = 50;
            this.pbPersonImage.Image = global::Book_Library.Properties.Resources.person_man;
            this.pbPersonImage.ImageRotate = 0F;
            this.pbPersonImage.Location = new System.Drawing.Point(12, 10);
            this.pbPersonImage.Name = "pbPersonImage";
            this.pbPersonImage.Size = new System.Drawing.Size(167, 136);
            this.pbPersonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPersonImage.TabIndex = 18;
            this.pbPersonImage.TabStop = false;
            this.pbPersonImage.Click += new System.EventHandler(this.pbPersonImage_Click);
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.White;
            this.guna2PictureBox2.BorderRadius = 50;
            this.guna2PictureBox2.Image = global::Book_Library.Properties.Resources.library__1_;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(576, 10);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(167, 136);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 22;
            this.guna2PictureBox2.TabStop = false;
            // 
            // frmHomeUserScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = global::Book_Library.Properties.Resources.BooksIcon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1565, 807);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbPersonImage);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.tvNavigationOptions);
            this.Controls.Add(this.flpScreen);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmHomeUserScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home User Screen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmHomeUserScreen_FormClosed);
            this.Load += new System.EventHandler(this.frmHomeUserScreen_Load);
            this.SizeChanged += new System.EventHandler(this.frmHomeUserScreen_SizeChanged);
            this.Move += new System.EventHandler(this.frmHomeUserScreen_Move);
            this.flpScreen.ResumeLayout(false);
            this.flpScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.cmsReturnBook.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvNavigationOptions;
        private System.Windows.Forms.FlowLayoutPanel flpScreen;
        private System.Windows.Forms.ContextMenuStrip cmsReturnBook;
        private System.Windows.Forms.ToolStripMenuItem tmsReturnBook;
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.Label lblNoRecord;
        private System.Windows.Forms.Label lblUsername;
        private Guna.UI2.WinForms.Guna2PictureBox pbPersonImage;
        private System.Windows.Forms.ImageList imageListIcons;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
    }
}