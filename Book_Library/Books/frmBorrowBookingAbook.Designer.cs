namespace Book_Library.Books
{
    partial class frmBorrowBookingAbook
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
            this.btnBorrowBooking = new Guna.UI2.WinForms.Guna2Button();
            this.ctrBookDetails1 = new Book_Library.Books.Controls.ctrBookDetails();
            this.SuspendLayout();
            // 
            // btnBorrowBooking
            // 
            this.btnBorrowBooking.BorderRadius = 20;
            this.btnBorrowBooking.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBorrowBooking.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBorrowBooking.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBorrowBooking.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBorrowBooking.FillColor = System.Drawing.Color.MediumBlue;
            this.btnBorrowBooking.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrowBooking.ForeColor = System.Drawing.Color.White;
            this.btnBorrowBooking.Image = global::Book_Library.Properties.Resources.borrow_book;
            this.btnBorrowBooking.ImageSize = new System.Drawing.Size(40, 40);
            this.btnBorrowBooking.Location = new System.Drawing.Point(953, 655);
            this.btnBorrowBooking.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrowBooking.Name = "btnBorrowBooking";
            this.btnBorrowBooking.Size = new System.Drawing.Size(270, 66);
            this.btnBorrowBooking.TabIndex = 4;
            this.btnBorrowBooking.Text = "Borrow";
            this.btnBorrowBooking.Click += new System.EventHandler(this.btnBorrowBooking_Click);
            // 
            // ctrBookDetails1
            // 
            this.ctrBookDetails1.AutoSize = true;
            this.ctrBookDetails1.BookID = 0;
            this.ctrBookDetails1.Location = new System.Drawing.Point(13, 2);
            this.ctrBookDetails1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctrBookDetails1.Name = "ctrBookDetails1";
            this.ctrBookDetails1.Size = new System.Drawing.Size(1048, 645);
            this.ctrBookDetails1.TabIndex = 0;
            // 
            // frmBorrowBookingAbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1250, 758);
            this.Controls.Add(this.btnBorrowBooking);
            this.Controls.Add(this.ctrBookDetails1);
            this.Name = "frmBorrowBookingAbook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrow/Booking A Book";
            this.Load += new System.EventHandler(this.frmBorrowBookingAbook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.ctrBookDetails ctrBookDetails1;
        private Guna.UI2.WinForms.Guna2Button btnBorrowBooking;
    }
}