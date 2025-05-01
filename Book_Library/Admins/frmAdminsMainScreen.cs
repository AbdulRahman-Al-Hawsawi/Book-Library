using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.WebSockets;
using System.Windows.Forms;
using Book_Library.Books;
using Book_Library.Books.Controls;
using Book_Library.GlobalClasses;
using Book_Library.Login;
using Book_Library.People;
using Book_Library.Properties;
using Book_Library.Users;
using BookLibrary_Business;

namespace Book_Library.Books
{
    public partial class frmAdminsMainScreen: Form
    {
        public frmAdminsMainScreen(frmLoginScreen logScreen)
        {
            InitializeComponent();
            _logScreen = logScreen;
        }
        enum enSideMenuScreens{ Books,Admins,Users,People }
        enSideMenuScreens _SelectedScreen = enSideMenuScreens.Books;

        frmLoginScreen _logScreen;
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            _logScreen.Show();
        }

        void AccessDeniedMessage()
        {
            MessageBox.Show("You don't have Permission for access to this section.\nContact your admin for more details", "Access denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        void AddBook(object sender,int BookID)
        {
            ctrBookCard BookCard = new ctrBookCard();
            clsBook Book = clsBook.Find(BookID);

            BookCard.BookID = Book.BookID;
            BookCard.BookName = Book.BookName;
            BookCard.AuthorName = Book.AuthorName;
            BookCard.ImagePath = Book.ImagePath;

            flpScreen.Controls.Add(BookCard);
        }

        private void frmMainScreen_Load(object sender, EventArgs e)
        {
            lblUsername.Text = clsGlobal.CurrentUser.Username;
        }

        private void frmAdminsMainScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            _logScreen.Close();
        }

        void ShowBooksList()
        {
            foreach (DataRow row in clsBook.GetAllBooks().Rows)
            {
                ctrBookCard Book = new ctrBookCard();
                Book.Mode = ctrBookCard.enMode.Admin;


                Book.BookID = (int)row["BookID"];
                Book.BookName = row["BookName"].ToString();
                Book.AuthorName = row["AuthorName"].ToString();
                Book.ImagePath = row["ImagePath"].ToString();

                flpScreen.Controls.Add(Book);
                flpScreen.ContextMenuStrip = Book.ContextMenuStrip;
                tvSubSideMenu.Visible = true;
            }
        }

        void ShowAdmins()
        {
            DataTable dt = clsUser.GetAllAdmins();
            if (dt.Rows.Count > 0)
            {
                dgvTable.BackgroundColor = Color.White;
                dgvTable.Visible = true;
                dgvTable.DataSource = dt;
                dgvTable.Size = new Size(flpScreen.Width - 170, flpScreen.Height - 5);
               
                frmAddUpdatePerson ddd = new frmAddUpdatePerson();
                flpScreen.Controls.Add(dgvTable);
                tvSubSideMenu.Height = flpScreen.Height - 5;
                flpScreen.Controls.Add(tvSubSideMenu);
                tvSubSideMenu.Visible = true;
               
            }
            else
            {
                dgvTable.Visible = false;
               
            }

        }

        void ShowUsers()
        {
            DataTable dt = clsUser.GetAllUsers();
            if (dt.Rows.Count > 0)
            {
                dgvTable.BackgroundColor = Color.White;
                dgvTable.Visible = true;
                dgvTable.DataSource = dt;
                dgvTable.Size = new Size(flpScreen.Width - 170, flpScreen.Height - 5);

                frmAddUpdatePerson ddd = new frmAddUpdatePerson();
                flpScreen.Controls.Add(dgvTable);

                tvSubSideMenu.Height = flpScreen.Height - 5;
                flpScreen.Controls.Add(tvSubSideMenu);
                tvSubSideMenu.Visible = true;

            }
            else
            {
                dgvTable.Visible = false;
                
            }

        }

        void ShowPeople()
        {
            DataTable dt = clsPerson.GetAllPeople();
            if (dt.Rows.Count > 0)
            {
                dgvTable.BackgroundColor = Color.White;
                dgvTable.Visible = true;
                dgvTable.DataSource = dt;
                dgvTable.Size = new Size(flpScreen.Width - 140, flpScreen.Height - 5);

                frmAddUpdatePerson ddd = new frmAddUpdatePerson();
                flpScreen.Controls.Add(dgvTable);

                tvSubSideMenu.Height = flpScreen.Height - 5;
                flpScreen.Controls.Add(tvSubSideMenu);
                tvSubSideMenu.Visible = true;

            }
            else
            {
                dgvTable.Visible = false;
                
            }

        }

        void ShowLogins()
        {
            DataTable dt = clsGlobal.GetAllApplicationEventLogs();
            if (dt.Rows.Count > 0)
            {
                dgvTable.BackgroundColor = Color.White;
                dgvTable.Visible = true;
                dgvTable.DataSource = dt;
                dgvTable.Size = new Size(flpScreen.Width - 170, flpScreen.Height - 5);
              
                flpScreen.Controls.Add(dgvTable);

                //tvSubSideMenu.Height = flpScreen.Height - 5;
                //flpScreen.Controls.Add(tvSubSideMenu);
                tvSubSideMenu.Visible = false;

            }
            else
            {
                dgvTable.Visible = false;

            }

        }
        private void tvSideMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            flpScreen.Controls.Clear();
            switch (e.Node.Text)
            {
                case "Books":                  
                        _SelectedScreen = enSideMenuScreens.Books;
                        ShowBooksList();
                   break;

                case "Admins":
                    if (clsGlobal.CheckIsUserHaveAccessPermissionFor(clsGlobal.enPermissions.ReadUsers))
                    {
                        _SelectedScreen = enSideMenuScreens.Admins;
                        ShowAdmins();
                    }
                    else
                        AccessDeniedMessage();
                    break;

                case "Users":
                    if (clsGlobal.CheckIsUserHaveAccessPermissionFor(clsGlobal.enPermissions.ReadUsers))
                    {
                        _SelectedScreen = enSideMenuScreens.Users;
                        ShowUsers();
                    }
                    else
                        AccessDeniedMessage();
                    break;

                case "People":
                    if (clsGlobal.CheckIsUserHaveAccessPermissionFor(clsGlobal.enPermissions.ReadUsers))
                    {
                        _SelectedScreen = enSideMenuScreens.People;
                         ShowPeople();
                    }
                    else
                        AccessDeniedMessage();
                    break;

                case "Logins":
                    if(clsGlobal.CurrentUser.Permissions == (int)clsGlobal.enPermissions.Full)
                    ShowLogins();
                    else
                        AccessDeniedMessage();
                    break;

                default:
                    flpScreen.Controls.Clear();
                    break;
            }
        }

        void AddNew()
        {
            if (!clsGlobal.CheckIsUserHaveAccessPermissionFor(clsGlobal.enPermissions.AddUsers))
            {
                AccessDeniedMessage();
                return;
            }
            
            switch (_SelectedScreen)
            {              
                case enSideMenuScreens.Admins:                                    
                 frmAddNewUser AddNewAdmin = new frmAddNewUser();
                 AddNewAdmin.ShowDialog();
                 break;

                case enSideMenuScreens.Users:                 
                 frmAddNewUser AddNewUser = new frmAddNewUser();
                 AddNewUser.ShowDialog();
                 break;

                case enSideMenuScreens.People:                 
                  frmAddUpdatePerson AddNewPerson = new frmAddUpdatePerson();
                  AddNewPerson.ShowDialog();
                  break;

                default:
                    //frmAddUpdatePerson AddNewPerson = new frmAddUpdatePerson();
                    //AddNewPerson.ShowDialog();
                    break;

            }
        }

        void Update()
        {
            if (!clsGlobal.CheckIsUserHaveAccessPermissionFor(clsGlobal.enPermissions.UpdateUsers))
            {
                AccessDeniedMessage(); 
                return;
            }

            switch (_SelectedScreen)
            {
                case enSideMenuScreens.Admins:
                    frmAddUpdateUserInfo UpdateAdminInfo = new frmAddUpdateUserInfo((int)dgvTable.CurrentRow.Cells["UserID"].Value,true);
                    UpdateAdminInfo.ShowDialog();
                    break;

                case enSideMenuScreens.Users:
                    frmAddUpdateUserInfo UpdateUserInfo = new frmAddUpdateUserInfo((int)dgvTable.CurrentRow.Cells["UserID"].Value, true);
                    UpdateUserInfo.ShowDialog();
                    break;

                case enSideMenuScreens.People:
                    frmAddUpdatePerson UpdatePerson = new frmAddUpdatePerson((int)dgvTable.CurrentRow.Cells["PersonID"].Value);
                    UpdatePerson.ShowDialog();
                    break;

            }
        }

        void Delete()
        {
            if (!clsGlobal.CheckIsUserHaveAccessPermissionFor(clsGlobal.enPermissions.DeleteUsers))
            {
                AccessDeniedMessage();
                return;
            }

            switch (_SelectedScreen)
            {
                case enSideMenuScreens.Admins:
                    if (MessageBox.Show("Are you sure you want to delete this Admin", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        if (clsUser.DeleteUser((int)dgvTable.CurrentRow.Cells["UserID"].Value))
                        {
                            dgvTable.DataSource = clsUser.GetAllAdmins();
                            MessageBox.Show("Delete Admin successfully");
                        }
                        else
                            MessageBox.Show("Delete Admin Faild");
                    break;

                case enSideMenuScreens.Users:
                    if (MessageBox.Show("Are you sure you want to delete this User", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        if (clsUser.DeleteUser((int)dgvTable.CurrentRow.Cells["UserID"].Value))
                        {
                            dgvTable.DataSource = clsUser.GetAllUsers();
                            MessageBox.Show("Delete User successfully");
                        }
                        else
                            MessageBox.Show("Delete User Faild");

                    break;
                case enSideMenuScreens.People:
                  if( MessageBox.Show("Are you sure you want to delete this person","Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                       if( clsPerson.DeletePerson((int)dgvTable.CurrentRow.Cells["PersonID"].Value))
                        {
                            dgvTable.DataSource = clsPerson.GetAllPeople();
                            MessageBox.Show("Delete person successfully");                           
                        }
                        else
                            MessageBox.Show("Delete person Faild");
                    break;

            }
        }

        private void tvSubSideMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (e.Node.Text)
            {
                case "Add":
                    AddNew();
                    break;

                case "Update":
                    Update();
                    break;

                case "Delete":
                    Delete();
                    break;

                default:
                 
                    break;
            }
        }

        private void tvSubSideMenu_Click(object sender, EventArgs e)
        {
            tvSubSideMenu.SelectedNode = null;
        }
    }
}
