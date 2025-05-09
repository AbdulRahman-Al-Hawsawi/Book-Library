using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Book_Library.Books.Controls;
using Book_Library.Login;
using BookLibrary_Business;
using FineLibrary_Business;
using Book_Library.GlobalClasses;
using Book_Library.Properties;
using Book_Library.Users;

namespace Book_Library.Books
{
    public partial class frmHomeUserScreen: Form
    {
        public frmHomeUserScreen()
        {
            InitializeComponent();
        }

        frmLoginScreen _frmLogin;
        public frmHomeUserScreen(frmLoginScreen frm = null )
        { 
             InitializeComponent();
            _frmLogin = frm;
        }

        private void frmHomeUserScreen_Load(object sender, EventArgs e)
        {
            if (clsGlobal.CurrentUser.PersonInfo.Gender == 0)
            {
                pbPersonImage.Image = Resources.person_man;
            }
            else
                pbPersonImage.Image = Resources.person_woman;

            lblUsername.Text = clsGlobal.CurrentUser.Username;
        }

        void ShowBooksList()
        {
            Random random = new Random();
            foreach (DataRow row in clsBook.GetAllBooks().Rows)
            {
                ctrBookCard Book = new ctrBookCard();
                Book.Mode = ctrBookCard.enMode.User;
                

                Book.BookID = (int)row["BookID"];
                Book.BookName = row["BookName"].ToString();
                Book.AuthorName = row["AuthorName"].ToString();
                Book.ImagePath = row["ImagePath"].ToString();
                Book.BookRating = (float)Convert.ToDouble(row["Rating"]);

                flpScreen.Controls.Add(Book);
            }
        }

        void ShowMyBooks()
        {
            DataTable dt = clsBook.GetAllUserBorrowedBooks(clsGlobal.CurrentUser.UserID);
            if (dt.Rows.Count > 0)
            {
                foreach(DataRow row in dt.Rows)
                {
                    ctrBorrowedBook BorrowedBook = new ctrBorrowedBook();
                    BorrowedBook.Click += RefrechBorrowedBooksScreen;
                    BorrowedBook.BookID = (int)row["BookID"];
                    BorrowedBook.CopyID = (int)row["Copy ID"];
                    BorrowedBook.DueDate =Convert.ToDateTime(row["Due Date"]).ToShortDateString();
                    flpScreen.Controls.Add(BorrowedBook);
                }
            }

            //if (dt.Rows.Count > 0)
            //{
            //    dgvTable.ContextMenuStrip = cmsReturnBook;
            //    dgvTable.DataSource = dt;
            //    dgvTable.Visible = true;
            //    dgvTable.Size = new Size(flpScreen.Width - 5, flpScreen.Height - 5);
            //    flpScreen.Controls.Add(dgvTable);
            //}
            else
            {
                dgvTable.Visible = false;
                lblNoRecord.Text = "There is no any Record ";
                lblNoRecord.Visible = true;
                flpScreen.Controls.Add(lblNoRecord);
            }
        }

        void ShowMetaphors()
        {
            DataTable dt = clsUser.GetAllUserMetaphors(clsGlobal.CurrentUser.UserID);
            if (dt.Rows.Count > 0)
            {
                dgvTable.BackgroundColor = Color.White;
                dgvTable.Visible = true;
                dgvTable.DataSource = dt;
                dgvTable.Size = new Size(flpScreen.Width - 5, flpScreen.Height - 5);
                flpScreen.Controls.Add(dgvTable);
            }
            else
            {
                dgvTable.Visible = false;
                lblNoRecord.Text = "There is no any Record";
                lblNoRecord.Visible = true;
                flpScreen.Controls.Add(lblNoRecord);
            }

        }

        void ShowFines()
        {
           
            DataTable dt = clsFine.GetAllUserFines(clsGlobal.CurrentUser.UserID);
            if (dt.Rows.Count > 0)
            {
                dgvTable.BackgroundColor = Color.White;
                dgvTable.Visible = true;
                dgvTable.DataSource = dt; dgvTable.Size = new Size(flpScreen.Width - 5, flpScreen.Height - 5);
                dgvTable.Size = new Size(flpScreen.Width - 5, flpScreen.Height - 5);
                flpScreen.Controls.Add(dgvTable);

            }
            else
            {
                dgvTable.Visible = false;
                lblNoRecord.Text = "There is no any Record";
                lblNoRecord.Visible = true;
                flpScreen.Controls.Add(lblNoRecord);
            }

        }

        void ShowUserReservations()
        {

            DataTable dt = clsReserve.GetAllUserReservations(clsGlobal.CurrentUser.UserID);
            if (dt.Rows.Count > 0)
            {
                dgvTable.BackgroundColor = Color.White;
                dgvTable.Visible = true;
                dgvTable.DataSource = dt;
                dgvTable.Size = new Size(flpScreen.Width - 5, flpScreen.Height - 5);
                flpScreen.Controls.Add(dgvTable);

            }
            else
            {
                dgvTable.Visible = false;
                lblNoRecord.Text = "There is no any Record";
                lblNoRecord.Visible = true;
                flpScreen.Controls.Add(lblNoRecord);

            }

        }

        void Logout()
        {         
            this.Close();
        }

        private void tvNavigationOptions_AfterSelect(object sender, TreeViewEventArgs e)
        {
            flpScreen.Controls.Clear();
            switch (e.Node.Text)
            {
                case "Books":
                    ShowBooksList();
                    break;

                case "My Books":
                   ShowMyBooks(); 
                    break;

                case "Metaphors":
                    ShowMetaphors();
                    break;

                case "Fines":
                    ShowFines();
                    break;

                case "Reservations":
                    ShowUserReservations();
                    break;

                    default:
                    flpScreen.Controls.Clear();
                    break;
            }

        }

        private void tmsReturnBook_Click(object sender, EventArgs e)
        {
            if (clsBook.ReturnBorrowedBook((int)dgvTable.SelectedRows[0].Cells[0].Value))
            {
                MessageBox.Show("Success Return");
                ShowMyBooks();
            }
            else
                MessageBox.Show("Faild Return");
        }

        private void dgvTable_Scroll(object sender, ScrollEventArgs e)
        {
             // MessageBox.Show("Old: " + e.OldValue + " New: " + e.NewValue);
        }

        private void frmHomeUserScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(Temp != null)
            Temp.Close();

            if(_frmLogin != null)
            _frmLogin.Show();
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void pbGenderImage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You will show user info here");
        }

        frmUserInfo Temp;
        private void pbPersonImage_Click(object sender, EventArgs e)
        {

            if (Temp == null)
            {
                frmUserInfo UserInfo = new frmUserInfo();
               // UserInfo.MdiParent = this;
                Temp = UserInfo;
               
                UserInfo.Logout += Logout;
                UserInfo.Show();
              //  UserInfo.BringToFront();
               
                return;
            }

            Temp.Close();
            Temp = null;



        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void RefrechBorrowedBooksScreen(object sender, EventArgs e)
        {
            ShowMyBooks();
        }

        private void frmHomeUserScreen_SizeChanged(object sender, EventArgs e)
        {
            if (Temp != null)
                Temp.Close();
        }

        private void frmHomeUserScreen_Move(object sender, EventArgs e)
        {
            if (Temp != null)
                Temp.Close();
        }
    }
}
