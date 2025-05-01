namespace Book_Library.Books
{
    partial class frmBookDetails
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
            this.ctrBookDetails1 = new Book_Library.Books.Controls.ctrBookDetails();
            this.SuspendLayout();
            // 
            // ctrBookDetails1
            // 
            this.ctrBookDetails1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrBookDetails1.Location = new System.Drawing.Point(0, 0);
            this.ctrBookDetails1.Name = "ctrBookDetails1";
            this.ctrBookDetails1.Size = new System.Drawing.Size(721, 457);
            this.ctrBookDetails1.TabIndex = 0;
            // 
            // frmBookDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 457);
            this.Controls.Add(this.ctrBookDetails1);
            this.Name = "frmBookDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Details";
            this.Load += new System.EventHandler(this.frmBookDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ctrBookDetails ctrBookDetails1;
    }
}