using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Book_Library.Books;
using BookLibrary_Business;
using System.IO;
using Book_Library.GlobalClasses;

namespace Book_Library.Books.Controls
{
    public partial class ctrBookCard: UserControl
    {
        public ctrBookCard()
        {
            InitializeComponent();
        }
        public enum enMode {Admin,User }

        public enMode Mode { get; set; }

        public int BookID { set; get; }
        public float BookRating 
        {
            get { return BookID; } set {ctrRatingBar1.SetBookRating(value); }
        
        }



        void ReloadBook()
        {
            clsBook Book = clsBook.Find(this.BookID);
            BookName = Book.BookName;
            AuthorName = Book.AuthorName;
            ImagePath = Book.ImagePath;
            
        }

        public string BookName
        {
            get 
            { 
                return lblBookName.Text; 
            }

            set
            {
                lblBookName.Text = value.Trim();
            }
        }

        public string AuthorName
        {
            get { return lblAuthorName.Text; }
            set { lblAuthorName.Text = value; }
        }

        public string ImagePath
        {
           get { return pbBookCoverImage.ImageLocation; }
           set 
            { 
                if(File.Exists(value))
                pbBookCoverImage.ImageLocation = value;
            }
        }

        public bool AvailabilityStatus
        {
            get { return AvailabilityStatus; }
            set
            {
                if (value)
                    lblAvailabilityStatus.Text = "Available";
                else
                    lblAvailabilityStatus.Text = "Not Available Now";

            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CheckIsUserHaveAccessPermissionFor(clsGlobal.enPermissions.UpdateBooks))
            {
                frmAddUpdateBook UpdateBookInfo = new frmAddUpdateBook(this.BookID);
                UpdateBookInfo.ShowDialog();
                ReloadBook();
            }
            else
                MessageBox.Show("You don't have Permission for access to this section.\nContact your admin for more details", "Access denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CheckIsUserHaveAccessPermissionFor(clsGlobal.enPermissions.DeleteBooks))
            {
                if(MessageBox.Show("Are sure you want to delete this Book?","Delete Book",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                if (clsBook.DeleteBook(this.BookID))
                {
                    this.ParentForm.Controls.Remove(this);
                    MessageBox.Show("Delete Book Successfully", "Delete Book");
                }
                else
                    MessageBox.Show("Delete Book Faild", "Delete Book");
            }
            else
                MessageBox.Show("You don't have Permission for access to this section.\nContact your admin for more details", "Access denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ctrBookCard_DoubleClick(object sender, EventArgs e)
        {
            frmBookDetails ShowBookDetails = new frmBookDetails(this.BookID);
            ShowBookDetails.ShowDialog();
        }

        private void ctrBookCard_Load(object sender, EventArgs e)
        {
            if(!clsBook.Find(this.BookID).IsAvailable())
            {
               AvailabilityStatus = false;
            }

            if (Mode == enMode.User)
            {
                pbBookCoverImage.DoubleClick += null;
                lblAuthorName.DoubleClick += null;
                lblBookName.DoubleClick += null;
                this.ContextMenuStrip = null;
                pbBookCoverImage.ContextMenuStrip = cmsUserOptions;
                lblBookName.ContextMenuStrip = cmsUserOptions;
                lblAuthorName.ContextMenuStrip = cmsUserOptions;

            }
        }

        private void tmsBorrow_Click(object sender, EventArgs e)
        {
            frmBorrowBookingAbook BorrowBookingAbook = new frmBorrowBookingAbook(this.BookID);
            BorrowBookingAbook.ShowDialog();              
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsGlobal.CheckIsUserHaveAccessPermissionFor(clsGlobal.enPermissions.AddBooks))
            {
                frmAddUpdateBook AddNewBook = new frmAddUpdateBook();
                AddNewBook.ShowDialog();
            }
            else
                MessageBox.Show("You don't have Permission for access to this section.\nContact your admin for more details", "Access denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

    }
}
