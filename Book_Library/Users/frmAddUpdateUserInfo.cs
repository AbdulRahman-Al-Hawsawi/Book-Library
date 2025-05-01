using Book_Library.GlobalClasses;
using BookLibrary_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Library.Users
{
    public partial class frmAddUpdateUserInfo: Form
    {
        public frmAddUpdateUserInfo(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
            _Mode = enMode.Add;
        }

        public frmAddUpdateUserInfo()
        {
            InitializeComponent();           
        }

        public frmAddUpdateUserInfo(int  UserID,bool UpdateUser =false)
        {
            InitializeComponent();
            _UserID = UserID;
            _Mode = enMode.Update;
        }

        enum enMode { Add,Update };
        enMode _Mode = enMode.Add;

        clsUser _User;
        int _PersonID;
        int _UserID;
        int GetUserPermissions()
        {
            int Permissions = 0;

            if(!chkIsAdmin.Checked) 
                return Permissions; /// return zero that mean is normal User not Admin

           
            if (chkAddBooks.Checked)
                Permissions += (int)clsGlobal.enPermissions.AddBooks;

            if(chkUpdateBooks.Checked)
                Permissions += (int)clsGlobal.enPermissions.UpdateBooks;

            if(chkDeleteBook.Checked)
                Permissions += (int)clsGlobal.enPermissions.DeleteBooks;

            if (chkReadUsers.Checked)
                Permissions += (int)clsGlobal.enPermissions.ReadUsers;

            if (chkAddUsers.Checked)
                Permissions += (int)clsGlobal.enPermissions.AddUsers;

            if (chkUpdateUsers.Checked)
                Permissions += (int)clsGlobal.enPermissions.UpdateUsers; ;

            if (chkDeleteUsers.Checked)
                Permissions += (int)clsGlobal.enPermissions.DeleteUsers;

            return Permissions;

        }

        void SetUserPermissions()
        {
            if(clsGlobal.CheckIsUserHaveAccessPermissionFor(_User,clsGlobal.enPermissions.Full))
                chkFullPermissions.Checked = true;

            if (clsGlobal.CheckIsUserHaveAccessPermissionFor(_User, clsGlobal.enPermissions.AddBooks))
                chkAddBooks.Checked = true;

            if (clsGlobal.CheckIsUserHaveAccessPermissionFor(_User, clsGlobal.enPermissions.UpdateBooks))
                chkUpdateBooks.Checked = true;

            if (clsGlobal.CheckIsUserHaveAccessPermissionFor(_User, clsGlobal.enPermissions.DeleteBooks))
                chkDeleteBook.Checked = true;

            if (clsGlobal.CheckIsUserHaveAccessPermissionFor(_User, clsGlobal.enPermissions.AddUsers))
                chkAddUsers.Checked = true;

            if (clsGlobal.CheckIsUserHaveAccessPermissionFor(_User, clsGlobal.enPermissions.UpdateUsers))
                chkUpdateUsers.Checked = true;

            if (clsGlobal.CheckIsUserHaveAccessPermissionFor(_User,clsGlobal.enPermissions.DeleteUsers))
                chkDeleteUsers.Checked = true;

        }
        private void chbIsAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIsAdmin.Checked)
            {
                gbPermissions.Visible = chkIsAdmin.Checked;
                gbPermissions.BringToFront();                
            }
            else
            {
                gbPermissions.Visible = false;              
            }

        }
        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            if (clsUser.isUserExist(tbUsername.Text.Trim()))
            {
                errorProvider1.SetError(tbUsername, "Not Valid");
            }
        }
        private void tbConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if(tbPassword.Text.Trim() != tbConfirmPassword.Text.Trim())
            {
                errorProvider1.SetError(tbConfirmPassword, "is not match");
            }
            
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
           ;

            if(_Mode == enMode.Add)
            _User.PersonID = _PersonID;
            
            _User.Username = tbUsername.Text.Trim();
            _User.Password = tbPassword.Text.Trim();
            _User.isAdmin = chkIsAdmin.Checked ? (byte) 1:(byte) 0;
            _User.Permissions = GetUserPermissions();

            if(_User.Save())
            {
                if(_Mode == enMode.Add)
                    MessageBox.Show("Add New User Successfully with ID: " + _User.UserID);
                else
                    MessageBox.Show("Update User Successfully");

                this.Close();
            }
            else
            {
                MessageBox.Show("Add or Update User Faild ");
            }
        }

        private void frmAddUpdateUserInfo_Load(object sender, EventArgs e)
        {

            chkIsAdmin.Visible = clsGlobal.CurrentUser != null && clsGlobal.CurrentUser.isAdmin == 1  ? true : false;
            if (_Mode == enMode.Update)
            {
                _User = clsUser.Find(_UserID);
                tbUsername.Text = _User.Username;
                tbPassword.Text = _User.Password;
                chkIsAdmin.Checked = Convert.ToBoolean(_User.isAdmin);
                SetUserPermissions();
            }
            else 
            { 
                _User = new clsUser();
            }
        }

        private void chkAddBooks_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkFullPermissions_CheckedChanged(object sender, EventArgs e)
        {
            chkAddBooks.Checked = true;
            chkUpdateBooks.Checked = true;
            chkDeleteBook.Checked = true;
            chkReadUsers.Checked = true;
            chkAddUsers.Checked = true;
            chkUpdateUsers.Checked = true;
            chkDeleteUsers.Checked = true;
        }
    }
}
