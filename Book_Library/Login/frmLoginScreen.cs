using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Book_Library.Properties;
using Book_Library.GlobalClasses;
using BookLibrary_Business;
using Book_Library.Books;
using System.Diagnostics;


namespace Book_Library.Login
{
    public partial class frmLoginScreen: Form
    {
        public frmLoginScreen()
        {
            InitializeComponent();
        }

        int NumberOfFailedLoginAttempts = 0;
        void ClearLoginInfo()
        {
            chkRememberMe.Checked = false;
            tbEmailOrUsername.Clear();
            tbPassword.Clear();
        }
        private void pbShowPassword_Click(object sender, EventArgs e)
        {
            //string PasswordValue = tbPassword.Text;

            //pbShowPassword.Image = Resources.Dont_show_password_icon_18;

            //if (pbShowPassword.Image == Resources.show_password_icon_17 )
            //{
            //    pbShowPassword.Image = null;
            //    pbShowPassword.Image = Resources.Dont_show_password_icon_18;
            //    tbPassword.PasswordChar = ' ' ;
            //    tbPassword.Text = PasswordValue;
               
            //}

            //else 
            //{
            //    pbShowPassword.Image = Resources.show_password_icon_17;
            //    tbPassword.PasswordChar = '*';
            //}
        }

        private void tbEmail_Enter(object sender, EventArgs e)
        {
            if (tbEmailOrUsername.Text == "Email")
                tbEmailOrUsername.Text = null;
        }

        private void tbEmail_Leave(object sender, EventArgs e)
        {
            if( string.IsNullOrWhiteSpace(tbEmailOrUsername.Text))
                tbEmailOrUsername.Text = "Email";
        }

        private void tbPassword_Enter(object sender, EventArgs e)
        {
            if( tbPassword.Text == "Password")
                tbPassword.Text = null;
        }

        private void tbPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbPassword.Text))
                tbPassword.Text = "Password";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           if( (clsGlobal.CurrentUser = clsUser.Find(tbEmailOrUsername.Text.Trim(),tbPassword.Text.Trim())) == null)
                clsGlobal.CurrentUser = clsUser.FindByUsernameAndPassword(tbEmailOrUsername.Text.Trim(),tbPassword.Text.Trim());

            if (clsGlobal.CurrentUser != null)
            {
               
                if(chkRememberMe.Checked)
                {
                    clsGlobal.RememberUsernameAndPassword(tbEmailOrUsername.Text.Trim(), tbPassword.Text.Trim());
                }
                else
                {
                    clsGlobal.RememberUsernameAndPassword("", "");
                }

                this.Hide();
                if (clsGlobal.CurrentUser.isAdmin == 1)
                {
                    clsGlobal.SaveToEventLog("Login to the system by User: " + tbEmailOrUsername.Text.Trim(), EventLogEntryType.Information);
                    frmAdminsMainScreen HomeScreen = new frmAdminsMainScreen(this);
                    HomeScreen.ShowDialog();
                }
                else
                {
                    frmHomeUserScreen HomeScreen = new frmHomeUserScreen(this);
                    HomeScreen.ShowDialog();
                }

            }
            else
            {
                MessageBox.Show("Login Faild");
                NumberOfFailedLoginAttempts++;
            }
            
            if(NumberOfFailedLoginAttempts ==3)
            {
                clsGlobal.SaveToEventLog("Three failed login attempts by User: " + tbEmailOrUsername.Text.Trim(), EventLogEntryType.Warning);
            }
        }

        private void frmLoginScreen_Load(object sender, EventArgs e)
        {
            string EmailOrUsername = "";
            string Password = "";
           if(clsGlobal.GetStoredCredintial(ref EmailOrUsername, ref Password))
            {
                chkRememberMe.Checked = true;
                tbEmailOrUsername.Text = EmailOrUsername;
                tbPassword.Text = Password;
            }
        }

      
        private void llblCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            ClearLoginInfo();
            frmSignUp SignUpScreen = new frmSignUp(this);  
            SignUpScreen.ShowDialog();
        }

        private void frmLoginScreen_VisibleChanged(object sender, EventArgs e)
        {
            if(!chkRememberMe.Checked)
            {
                tbEmailOrUsername.Text =null;
                tbPassword.Text = null;
            }
        }
    }
}
