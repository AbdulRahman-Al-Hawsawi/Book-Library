using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookLibrary_Business;

namespace Book_Library.Books
{
    public partial class frmAddUpdateBook: Form
    {
        public frmAddUpdateBook()
        {
            InitializeComponent();
        }

        public frmAddUpdateBook(int BookID)
        {
            InitializeComponent();
            _BookID = BookID;
        }

        enum enMode { Add,Update};
        enMode Mode = enMode.Add;
        clsBook _Book;

        int _BookID = -1;

        public delegate void DataBackHandler(object sender, int BookID);
        public event DataBackHandler ReturnBookID;

        void SetValues(int BookID)
        {
            if(BookID == -1)
            {
                Mode = enMode.Add;
                this.Text = "Add New Book";
                _Book = new clsBook();
                return;
            }

            Mode = enMode.Update;
            this.Text = "Update Book Info";

            _Book = clsBook.Find(BookID);
            lblBookID.Text         = _Book.BookID.ToString();
            tbBookName.Text        = _Book.BookName;
            tbAuthorName.Text      = _Book.AuthorName;
            tbISBN.Text            = _Book.ISBN;
            tbBookDescription.Text = _Book.BookDescription;
            tbNumberOfCopies.Text = _Book.NumberOfCopies.ToString();
            pbBookCoverImage.ImageLocation = _Book.ImagePath;
        }
        private void guna2TextBox1_Leave(object sender, EventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(((TextBox)sender).Text))
            //    ((TextBox)sender).Text = ((TextBox)sender).Tag.ToString();
        }

        private void tbBookName_Enter(object sender, EventArgs e)
        {
            if (tbBookName.Text == "Book Name")
                tbBookName.Text = null;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            _Book.BookName = tbBookName.Text.Trim();
            _Book.AuthorName = tbAuthorName.Text.Trim();
            _Book.ISBN = tbISBN.Text.Trim();
            _Book.BookDescription = tbBookDescription.Text.Trim();
            _Book.NumberOfCopies = Convert.ToInt32(tbNumberOfCopies.Text);

            if (!string.IsNullOrEmpty(pbBookCoverImage.ImageLocation) && pbBookCoverImage.ImageLocation != _Book.ImagePath)
               _Book.ImagePath = pbBookCoverImage.ImageLocation;
               
            if (_Book.Save())
            {
                if(Mode == enMode.Add)
                { 
                  lblBookID.Text = _Book.BookID.ToString();
                    MessageBox.Show("Add New Book Successfully", "Add New Book", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Update Book info Successfully", ";Update Book", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

               if(Mode == enMode.Add)
                ReturnBookID(this, _Book.BookID);
            }
            else
                MessageBox.Show("Add/Update Book Faild");
        }

        private void llblUploadCoverImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ofdUploadBookCoverImage.Title = "Upload Book Cover";
            ofdUploadBookCoverImage.InitialDirectory = "C:\\Users\\Abdulrahman\\Desktop\\Icons";
            ofdUploadBookCoverImage.DefaultExt = "(*.jpg)| *.jpg (*.png)| *.png (*.jpeg)| *.jpeg ";

            if(ofdUploadBookCoverImage.ShowDialog() == DialogResult.OK)
            {
                pbBookCoverImage.ImageLocation = ofdUploadBookCoverImage.FileName;
            }
        }

        private void tbBookName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbBookName.Text))
                tbBookName.Text = "Book Name";
        }

        private void tbAuthorName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbAuthorName.Text))
                tbAuthorName.Text = "Author";
        }

        private void tbAuthorName_Enter(object sender, EventArgs e)
        {
            if (tbAuthorName.Text == "Author")
                tbAuthorName.Text = null;
        }

        private void tbISBN_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbISBN.Text))
                tbISBN.Text = "ISBN";
        }

        private void tbISBN_Enter(object sender, EventArgs e)
        {
            if (tbISBN.Text == "ISBN")
                tbISBN.Text = null;
        }

        private void tbBookDescription_Enter(object sender, EventArgs e)
        {
            if(tbBookDescription.Text == "Description")
            tbBookDescription.Text = null;
        }

        private void tbBookDescription_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbBookDescription.Text))
                tbBookDescription.Text = "Description";
        }

        private void frmAddUpdateBook_Load(object sender, EventArgs e)
        {
            SetValues(_BookID);
        }

        private void tbNumberOfCopies_Enter(object sender, EventArgs e)
        {
            if (tbNumberOfCopies.Text == "Quantity")
                tbNumberOfCopies.Text = null;
        }

        private void tbNumberOfCopies_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNumberOfCopies.Text))
                tbNumberOfCopies.Text = "Quantity";
        }
    }
}
