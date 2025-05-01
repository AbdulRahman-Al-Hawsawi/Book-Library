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
using Book_Library.GlobalClasses;

namespace Book_Library.Books.Controls
{
    public partial class ctrBorrowedBook: UserControl
    {
        public ctrBorrowedBook()
        {
            InitializeComponent();
        }

        clsBook _Book;
        public int CopyID { get; set; }
        public int BookID
        {
            get { return BookID; }
        set
            {
                LoadBookInfo(value);
            }
        }

        public string DueDate
        {
            get { return DueDate; } 
          set { lblDueDate.Text = value; }
        }

        public void LoadBookInfo(int BookID)
        {
             _Book =  clsBook.Find(BookID);

            if (_Book != null)
            {
                pbBookCoverImage.ImageLocation = _Book.ImagePath;
            }
        }
        void SendNotificationThatACopyOfTheBookIsAvailable(int CopyID)
        {
            int UserID = clsReserve.ReturnUserIdFromReservationsTableToSendBookAvailable(CopyID);
            clsUser UserInfo = clsUser.Find(UserID);
            string Subject = "Book Available";
            string Body = "We would like to inform you\n that the copy of the book you reserved,is now available";
           
            if (clsUtil.SendEmail(UserInfo.PersonInfo.Email, Subject, Body))
                MessageBox.Show("Send email Successfully");
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to return the book?\n You cannot get a refund even if the period has not ended.", "Confirm return book", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (clsBook.ReturnBorrowedBook(CopyID))
                {
                    // MessageBox.Show("Success Return");
                    this.Hide();
                    SendNotificationThatACopyOfTheBookIsAvailable(CopyID);

                }
                else
                    MessageBox.Show("Faild Return");
            }
        }

       
    }
}
