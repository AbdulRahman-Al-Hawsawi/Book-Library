namespace Book_Library.Books
{
    partial class frmAddUpdateBook
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
            this.tbBookName = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbNumberOfCopies = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbAuthorName = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbISBN = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBookID = new System.Windows.Forms.Label();
            this.llblUploadCoverImage = new System.Windows.Forms.LinkLabel();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ofdUploadBookCoverImage = new System.Windows.Forms.OpenFileDialog();
            this.pbBookCoverImage = new System.Windows.Forms.PictureBox();
            this.tbBookDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.ttMessage = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBookCoverImage)).BeginInit();
            this.SuspendLayout();
            // 
            // tbBookName
            // 
            this.tbBookName.BorderRadius = 20;
            this.tbBookName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbBookName.DefaultText = "Book Name";
            this.tbBookName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbBookName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbBookName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbBookName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbBookName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbBookName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBookName.ForeColor = System.Drawing.Color.Black;
            this.tbBookName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbBookName.Location = new System.Drawing.Point(262, 40);
            this.tbBookName.Name = "tbBookName";
            this.tbBookName.PlaceholderText = "";
            this.tbBookName.SelectedText = "";
            this.tbBookName.Size = new System.Drawing.Size(273, 70);
            this.tbBookName.TabIndex = 10;
            this.tbBookName.Tag = " Book Name";
            this.tbBookName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbBookName.Enter += new System.EventHandler(this.tbBookName_Enter);
            this.tbBookName.Leave += new System.EventHandler(this.tbBookName_Leave);
            // 
            // tbNumberOfCopies
            // 
            this.tbNumberOfCopies.BorderRadius = 20;
            this.tbNumberOfCopies.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNumberOfCopies.DefaultText = "Quantity";
            this.tbNumberOfCopies.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbNumberOfCopies.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbNumberOfCopies.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNumberOfCopies.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNumberOfCopies.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNumberOfCopies.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumberOfCopies.ForeColor = System.Drawing.Color.Black;
            this.tbNumberOfCopies.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNumberOfCopies.Location = new System.Drawing.Point(261, 93);
            this.tbNumberOfCopies.Name = "tbNumberOfCopies";
            this.tbNumberOfCopies.PlaceholderText = "";
            this.tbNumberOfCopies.SelectedText = "";
            this.tbNumberOfCopies.Size = new System.Drawing.Size(273, 41);
            this.tbNumberOfCopies.TabIndex = 11;
            this.tbNumberOfCopies.Tag = "Quantity";
            this.tbNumberOfCopies.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ttMessage.SetToolTip(this.tbNumberOfCopies, "If you do not enter the quantity, the system will automatically define one copy.");
            this.tbNumberOfCopies.Enter += new System.EventHandler(this.tbNumberOfCopies_Enter);
            this.tbNumberOfCopies.Leave += new System.EventHandler(this.tbNumberOfCopies_Leave);
            // 
            // tbAuthorName
            // 
            this.tbAuthorName.BorderRadius = 20;
            this.tbAuthorName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbAuthorName.DefaultText = "Author";
            this.tbAuthorName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbAuthorName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbAuthorName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAuthorName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbAuthorName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAuthorName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAuthorName.ForeColor = System.Drawing.Color.Black;
            this.tbAuthorName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbAuthorName.Location = new System.Drawing.Point(262, 3);
            this.tbAuthorName.Name = "tbAuthorName";
            this.tbAuthorName.PlaceholderText = "";
            this.tbAuthorName.SelectedText = "";
            this.tbAuthorName.Size = new System.Drawing.Size(273, 41);
            this.tbAuthorName.TabIndex = 12;
            this.tbAuthorName.Tag = "Author";
            this.tbAuthorName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbAuthorName.Enter += new System.EventHandler(this.tbAuthorName_Enter);
            this.tbAuthorName.Leave += new System.EventHandler(this.tbAuthorName_Leave);
            // 
            // tbISBN
            // 
            this.tbISBN.BorderRadius = 20;
            this.tbISBN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbISBN.DefaultText = "ISBN";
            this.tbISBN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbISBN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbISBN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbISBN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbISBN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbISBN.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbISBN.ForeColor = System.Drawing.Color.Black;
            this.tbISBN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbISBN.Location = new System.Drawing.Point(262, 46);
            this.tbISBN.Name = "tbISBN";
            this.tbISBN.PlaceholderText = "";
            this.tbISBN.SelectedText = "";
            this.tbISBN.Size = new System.Drawing.Size(273, 41);
            this.tbISBN.TabIndex = 13;
            this.tbISBN.Tag = "ISBN";
            this.tbISBN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbISBN.Enter += new System.EventHandler(this.tbISBN_Enter);
            this.tbISBN.Leave += new System.EventHandler(this.tbISBN_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(262, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Book ID:";
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBookID.Location = new System.Drawing.Point(364, 9);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(29, 25);
            this.lblBookID.TabIndex = 16;
            this.lblBookID.Text = "#";
            // 
            // llblUploadCoverImage
            // 
            this.llblUploadCoverImage.AutoSize = true;
            this.llblUploadCoverImage.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblUploadCoverImage.Location = new System.Drawing.Point(32, 324);
            this.llblUploadCoverImage.Name = "llblUploadCoverImage";
            this.llblUploadCoverImage.Size = new System.Drawing.Size(200, 18);
            this.llblUploadCoverImage.TabIndex = 0;
            this.llblUploadCoverImage.TabStop = true;
            this.llblUploadCoverImage.Text = "Upload Book Cover Image";
            this.llblUploadCoverImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblUploadCoverImage_LinkClicked);
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
            this.btnSave.Location = new System.Drawing.Point(35, 372);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 45);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumBlue;
            this.panel1.Controls.Add(this.tbAuthorName);
            this.panel1.Controls.Add(this.tbISBN);
            this.panel1.Controls.Add(this.tbNumberOfCopies);
            this.panel1.Location = new System.Drawing.Point(1, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 146);
            this.panel1.TabIndex = 18;
            // 
            // ofdUploadBookCoverImage
            // 
            this.ofdUploadBookCoverImage.FileName = "openFileDialog1";
            // 
            // pbBookCoverImage
            // 
            this.pbBookCoverImage.Image = global::Book_Library.Properties.Resources.BookCover1;
            this.pbBookCoverImage.Location = new System.Drawing.Point(9, 12);
            this.pbBookCoverImage.Name = "pbBookCoverImage";
            this.pbBookCoverImage.Size = new System.Drawing.Size(247, 309);
            this.pbBookCoverImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBookCoverImage.TabIndex = 14;
            this.pbBookCoverImage.TabStop = false;
            // 
            // tbBookDescription
            // 
            this.tbBookDescription.AutoScroll = true;
            this.tbBookDescription.BorderRadius = 20;
            this.tbBookDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbBookDescription.DefaultText = "Description";
            this.tbBookDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbBookDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbBookDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbBookDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbBookDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbBookDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBookDescription.ForeColor = System.Drawing.Color.Black;
            this.tbBookDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbBookDescription.Location = new System.Drawing.Point(262, 268);
            this.tbBookDescription.Name = "tbBookDescription";
            this.tbBookDescription.PlaceholderText = "";
            this.tbBookDescription.SelectedText = "";
            this.tbBookDescription.Size = new System.Drawing.Size(282, 170);
            this.tbBookDescription.TabIndex = 14;
            this.tbBookDescription.Tag = "Description";
            this.tbBookDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbBookDescription.Enter += new System.EventHandler(this.tbBookDescription_Enter);
            this.tbBookDescription.Leave += new System.EventHandler(this.tbBookDescription_Leave);
            // 
            // ttMessage
            // 
            this.ttMessage.IsBalloon = true;
            // 
            // frmAddUpdateBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(556, 450);
            this.Controls.Add(this.tbBookDescription);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.llblUploadCoverImage);
            this.Controls.Add(this.lblBookID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbBookCoverImage);
            this.Controls.Add(this.tbBookName);
            this.Controls.Add(this.panel1);
            this.Name = "frmAddUpdateBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddUpdateBook";
            this.Load += new System.EventHandler(this.frmAddUpdateBook_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBookCoverImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox tbBookName;
        private Guna.UI2.WinForms.Guna2TextBox tbNumberOfCopies;
        private Guna.UI2.WinForms.Guna2TextBox tbAuthorName;
        private Guna.UI2.WinForms.Guna2TextBox tbISBN;
        private System.Windows.Forms.PictureBox pbBookCoverImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.LinkLabel llblUploadCoverImage;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.OpenFileDialog ofdUploadBookCoverImage;
        private Guna.UI2.WinForms.Guna2TextBox tbBookDescription;
        private System.Windows.Forms.ToolTip ttMessage;
    }
}