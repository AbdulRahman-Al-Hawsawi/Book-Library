using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Book_Library.Properties;
using BookLibrary_Business;
using Book_Library.Users;
using Book_Library.Login;
using Book_Library.GlobalClasses;

namespace Book_Library
{
    public partial class frmSignUp: Form
    {
        public frmSignUp(frmLoginScreen frm = null)
        {
            InitializeComponent();
            _frmLoginScreen = frm;
        }

        frmLoginScreen _frmLoginScreen;

        void Save(bool IsValidEmail)
        {
            if (IsValidEmail)
            {
                clsPerson NewPerson = new clsPerson();

                NewPerson.FirstName = tbFirstName.Text.Trim();
                NewPerson.SecondName = tbSecondName.Text.Trim();
                NewPerson.ThirdName = tbThirdName.Text.Trim();
                NewPerson.LastName = tbLastName.Text.Trim();
                NewPerson.Email = tbEmail.Text.Trim();
                NewPerson.Phone = tbPhone.Text.Trim();
                NewPerson.Address = tbAddress.Text.Trim();
                NewPerson.DateOfBirth = dtpDateOfBirth.Value;
                NewPerson.Gender = rbMale.Checked ? (byte)0 : (byte)1;

                if (NewPerson.Save())
                {
                    MessageBox.Show("Successfully Sign Up ID : " + NewPerson.PersonID, "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmAddUpdateUserInfo AddUserInfo = new frmAddUpdateUserInfo(NewPerson.PersonID);
                    AddUserInfo.ShowDialog();
                    MessageBox.Show("Done, Login with Your User Credentials ", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    _frmLoginScreen.Show();

                }
                else
                    MessageBox.Show("Invalid Sign Up", "Sign Up", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

            }
            else
            {
                MessageBox.Show("Invalid Email \n Check Your Email");
                tbEmail.Focus();
            }
        }
        //void SendMessageToConfirmEmail()
        //{
        //    if(clsUtil.SendEmail("Abdu75p@gmail.com", "AbdulrahmanHawsawi75@gmail.com","Book Library","Enter this code to confirm your Email\n" + clsUtil.GenerateRandomNumber(6)))
        //    {

        //    }
        //}
        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            pbGenderImage.Image = Resources.Unknwonperson_man;
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            pbGenderImage.Image = Resources.UnknwonPerson_girl;
        }

        private void tbPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!char.IsDigit(e.KeyChar)) ? true : false;
        }

        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar) || char.IsSymbol(e.KeyChar) ? true : false;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            frmConfirmEmail ConfirmEmail = new frmConfirmEmail(tbEmail.Text.Trim());
            ConfirmEmail.ReturnTheMatchResult += Save;
            ConfirmEmail.ShowDialog();

            //clsPerson NewPerson = new clsPerson();

            //NewPerson.FirstName = tbFirstName.Text.Trim();
            //NewPerson.SecondName = tbSecondName.Text.Trim();
            //NewPerson.ThirdName = tbThirdName.Text.Trim();
            //NewPerson.LastName = tbLastName.Text.Trim();
            //NewPerson.Email = tbEmail.Text.Trim();
            //NewPerson.Phone = tbPhone.Text.Trim();
            //NewPerson.Address = tbAddress.Text.Trim();
            //NewPerson.DateOfBirth = dtpDateOfBirth.Value;
            //NewPerson.Gender = rbMale.Checked ? (byte)0 : (byte)1;

            //if (NewPerson.Save())
            //{
            //    MessageBox.Show("Successfully Sign Up ID : " + NewPerson.PersonID, "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    frmAddUpdateUserInfo AddUserInfo = new frmAddUpdateUserInfo(NewPerson.PersonID);
            //    AddUserInfo.ShowDialog();
            //    MessageBox.Show("Done, Login with Your User Credentials ", "Sign Up", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    this.Close();
            //    _frmLoginScreen.Show();

            //}
            //else
            //    MessageBox.Show("Invalid Sign Up", "Sign Up", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

        }

       
        private void frmSignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            _frmLoginScreen.Show();
        }
    }
}

