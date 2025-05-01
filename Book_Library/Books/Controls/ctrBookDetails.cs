using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookLibrary_Business;
using System.IO;

namespace Book_Library.Books.Controls
{
    public partial class ctrBookDetails: UserControl
    {
        public ctrBookDetails()
        {
            InitializeComponent();
        }

        private void ctrBookDetails_Load(object sender, EventArgs e)
        {

        }

        public int BookID { get; set; }

        public void LoadBookDetails(int BookID)
        {
            this.BookID = BookID;
            clsBook Book = clsBook.Find(BookID);

            lblBookID.Text = Book.BookID.ToString();
            lblBookName.Text = Book.BookName.ToUpper();
            lblAuthorName.Text = Book.AuthorName;
            lblISBN.Text = Book.ISBN;
            lblBookDescription.Text = Book.BookDescription;

            if (File.Exists(Book.ImagePath))
                pbBookCoverImage.ImageLocation = Book.ImagePath;

        }
    }
}
