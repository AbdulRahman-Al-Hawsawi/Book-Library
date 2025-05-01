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
using Book_Library.GlobalClasses;

namespace Book_Library.Books
{
    public partial class frmBorrowBookingAbook: Form
    {
        public frmBorrowBookingAbook(int BookID)
        {
            InitializeComponent();
            _BookID = BookID;
        }

        int _BookID;

        private void frmBorrowBookingAbook_Load(object sender, EventArgs e)
        {
            if(!clsBook.Find(_BookID).IsAvailable())
            {
                btnBorrowBooking.Text = "Reserve";
                MessageBox.Show("There is no copies available now,\nYou can reserve and you will be notified when a copy is available", "Booked", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            ctrBookDetails1.LoadBookDetails(_BookID);
        }

        private void btnBorrowBooking_Click(object sender, EventArgs e)
        {
            if (!clsBook.Find(_BookID).IsAvailable())
            {
                clsReserve ReserveBook = new clsReserve();   
                ReserveBook.BookID = _BookID;
                ReserveBook.UserID = clsGlobal.CurrentUser.UserID;
                
                if(ReserveBook.Save())
                    MessageBox.Show("Booked successfully,\nYou will be notified when a copy is available", "Booked", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Reservation Failed,\nTry again", "Reservation", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                if (clsBook.Borrow(clsGlobal.CurrentUser.UserID, ctrBookDetails1.BookID))
                    MessageBox.Show("Borrow is successfully");
                else
                    MessageBox.Show("Borrow is faild try again");
            }
        }
    }
}
