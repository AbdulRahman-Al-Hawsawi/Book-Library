namespace Book_Library.Books.Controls
{
    partial class ctrBookCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrBookCard));
            this.lblAvailabilityStatus = new System.Windows.Forms.Label();
            this.lblAuthorName = new System.Windows.Forms.Label();
            this.cmsAdminOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBookName = new System.Windows.Forms.Label();
            this.cmsUserOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tmsBorrow = new System.Windows.Forms.ToolStripMenuItem();
            this.pbBookCoverImage = new System.Windows.Forms.PictureBox();
            this.ctrRatingBar1 = new Book_Library.Books.Controls.ctrRatingBar();
            this.cmsAdminOptions.SuspendLayout();
            this.cmsUserOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBookCoverImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAvailabilityStatus
            // 
            this.lblAvailabilityStatus.AutoSize = true;
            this.lblAvailabilityStatus.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailabilityStatus.ForeColor = System.Drawing.Color.Red;
            this.lblAvailabilityStatus.Location = new System.Drawing.Point(4, 4);
            this.lblAvailabilityStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAvailabilityStatus.Name = "lblAvailabilityStatus";
            this.lblAvailabilityStatus.Size = new System.Drawing.Size(97, 24);
            this.lblAvailabilityStatus.TabIndex = 1;
            this.lblAvailabilityStatus.Text = "Available ";
            // 
            // lblAuthorName
            // 
            this.lblAuthorName.AutoSize = true;
            this.lblAuthorName.ContextMenuStrip = this.cmsAdminOptions;
            this.lblAuthorName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthorName.Location = new System.Drawing.Point(4, 436);
            this.lblAuthorName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuthorName.Name = "lblAuthorName";
            this.lblAuthorName.Size = new System.Drawing.Size(126, 24);
            this.lblAuthorName.TabIndex = 2;
            this.lblAuthorName.Text = "Eckhart Tolle";
            this.lblAuthorName.DoubleClick += new System.EventHandler(this.ctrBookCard_DoubleClick);
            // 
            // cmsAdminOptions
            // 
            this.cmsAdminOptions.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsAdminOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.cmsAdminOptions.Name = "cmsBookOptions";
            this.cmsAdminOptions.Size = new System.Drawing.Size(203, 172);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.BackColor = System.Drawing.Color.AntiqueWhite;
            this.addToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.addToolStripMenuItem.Image = global::Book_Library.Properties.Resources.book_add;
            this.addToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(202, 56);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.BackColor = System.Drawing.Color.AntiqueWhite;
            this.editToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editToolStripMenuItem.Image = global::Book_Library.Properties.Resources.book_config;
            this.editToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(202, 56);
            this.editToolStripMenuItem.Text = "Update ";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.BackColor = System.Drawing.Color.AntiqueWhite;
            this.deleteToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteToolStripMenuItem.Image = global::Book_Library.Properties.Resources.book_delete;
            this.deleteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(202, 56);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // lblBookName
            // 
            this.lblBookName.ContextMenuStrip = this.cmsAdminOptions;
            this.lblBookName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookName.Location = new System.Drawing.Point(4, 395);
            this.lblBookName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(303, 38);
            this.lblBookName.TabIndex = 3;
            this.lblBookName.Text = "Power of now";
            this.lblBookName.DoubleClick += new System.EventHandler(this.ctrBookCard_DoubleClick);
            // 
            // cmsUserOptions
            // 
            this.cmsUserOptions.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsUserOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmsBorrow});
            this.cmsUserOptions.Name = "cmsBookOptions";
            this.cmsUserOptions.Size = new System.Drawing.Size(153, 42);
            // 
            // tmsBorrow
            // 
            this.tmsBorrow.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tmsBorrow.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tmsBorrow.Image = ((System.Drawing.Image)(resources.GetObject("tmsBorrow.Image")));
            this.tmsBorrow.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tmsBorrow.Name = "tmsBorrow";
            this.tmsBorrow.Size = new System.Drawing.Size(152, 38);
            this.tmsBorrow.Text = "Borrw";
            this.tmsBorrow.Click += new System.EventHandler(this.tmsBorrow_Click);
            // 
            // pbBookCoverImage
            // 
            this.pbBookCoverImage.ContextMenuStrip = this.cmsAdminOptions;
            this.pbBookCoverImage.Location = new System.Drawing.Point(4, 4);
            this.pbBookCoverImage.Margin = new System.Windows.Forms.Padding(4);
            this.pbBookCoverImage.Name = "pbBookCoverImage";
            this.pbBookCoverImage.Size = new System.Drawing.Size(303, 386);
            this.pbBookCoverImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBookCoverImage.TabIndex = 0;
            this.pbBookCoverImage.TabStop = false;
            this.pbBookCoverImage.DoubleClick += new System.EventHandler(this.ctrBookCard_DoubleClick);
            // 
            // ctrRatingBar1
            // 
            this.ctrRatingBar1.Enabled = false;
            this.ctrRatingBar1.Location = new System.Drawing.Point(8, 464);
            this.ctrRatingBar1.Name = "ctrRatingBar1";
            this.ctrRatingBar1.Size = new System.Drawing.Size(287, 58);
            this.ctrRatingBar1.TabIndex = 4;
            // 
            // ctrBookCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ContextMenuStrip = this.cmsAdminOptions;
            this.Controls.Add(this.ctrRatingBar1);
            this.Controls.Add(this.lblBookName);
            this.Controls.Add(this.lblAuthorName);
            this.Controls.Add(this.lblAvailabilityStatus);
            this.Controls.Add(this.pbBookCoverImage);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ctrBookCard";
            this.Size = new System.Drawing.Size(315, 525);
            this.Load += new System.EventHandler(this.ctrBookCard_Load);
            this.DoubleClick += new System.EventHandler(this.ctrBookCard_DoubleClick);
            this.cmsAdminOptions.ResumeLayout(false);
            this.cmsUserOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBookCoverImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBookCoverImage;
        private System.Windows.Forms.Label lblAvailabilityStatus;
        private System.Windows.Forms.Label lblAuthorName;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.ContextMenuStrip cmsAdminOptions;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsUserOptions;
        private System.Windows.Forms.ToolStripMenuItem tmsBorrow;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private ctrRatingBar ctrRatingBar1;
        //  private ctrRatingBar ctrRatingBar1;
    }
}
