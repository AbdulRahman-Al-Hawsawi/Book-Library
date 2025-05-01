namespace Book_Library.Users
{
    partial class frmUserInfo
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode(".....", -2, -2);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Me", -2, -2);
            this.tvNavigationOptions = new System.Windows.Forms.TreeView();
            this.btnSignOut = new System.Windows.Forms.Button();
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
            this.tvNavigationOptions.Location = new System.Drawing.Point(3, 4);
            this.tvNavigationOptions.Margin = new System.Windows.Forms.Padding(4);
            this.tvNavigationOptions.Name = "tvNavigationOptions";
            treeNode1.Checked = true;
            treeNode1.ImageIndex = -2;
            treeNode1.Name = "aaaa";
            treeNode1.SelectedImageIndex = -2;
            treeNode1.Text = ".....";
            treeNode2.ImageIndex = -2;
            treeNode2.Name = "Me";
            treeNode2.SelectedImageIndex = -2;
            treeNode2.Text = "Me";
            this.tvNavigationOptions.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.tvNavigationOptions.ShowLines = false;
            this.tvNavigationOptions.Size = new System.Drawing.Size(259, 458);
            this.tvNavigationOptions.TabIndex = 4;
            this.tvNavigationOptions.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvNavigationOptions_AfterSelect);
            // 
            // btnSignOut
            // 
            this.btnSignOut.Image = global::Book_Library.Properties.Resources.sign_out;
            this.btnSignOut.Location = new System.Drawing.Point(60, 337);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(139, 109);
            this.btnSignOut.TabIndex = 8;
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // frmUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 562);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.tvNavigationOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(5, 130);
            this.Name = "frmUserInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmUserInfo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvNavigationOptions;
        private System.Windows.Forms.Button btnSignOut;
    }
}