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
using Book_Library.Properties;
using Book_Library.GlobalClasses;
using Book_Library.Users;

namespace Book_Library.People
{
    public partial class ctrAddUpdatePerson: UserControl
    {
        public ctrAddUpdatePerson()
        {
            InitializeComponent();
        }

        enum enMode { Add, Update };
        enMode _Mode;
        int _PersonID = -1;
        clsPerson _Person;

        public void LoadPersonInfo(int PersonID)
        {
            _PersonID = PersonID;
            if (_PersonID == -1)
            {
                _Mode = enMode.Add;
            }
            else
                _Mode = enMode.Update;
            _LoadData();
        }

        void _LoadData()
        {
           

            if (_Mode == enMode.Add)
            {
                if (clsGlobal.CurrentUser == null)
                    lblTitle.Text = "Sign Up";
                else
                    lblTitle.Text = "Add New Person";

                    _Person = new clsPerson();
                DateTime MaximumDate = DateTime.Now;
                dtpDateOfBirth.MaxDate = MaximumDate.AddYears(-18);
                return;
            }

            _Person = clsPerson.Find(_PersonID);

            if (_Person == null)
            {
                MessageBox.Show("This form will be closed because the Person is not exists");
                /// make delegate to close the form
            }

            lblTitle.Text = "Update";
            tbFirstName.Text = _Person.FirstName;
            tbSecondName.Text = _Person.SecondName;
            tbThirdName.Text = _Person.ThirdName;
            tbLastName.Text = _Person.LastName;
            tbAddress.Text = _Person.Address;
            tbPhone.Text = _Person.Phone;
            tbEmail.Text = _Person.Email;
            dtpDateOfBirth.Value = _Person.DateOfBirth;
          
            if (_Person.Gender == 0)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _Person.FirstName = tbFirstName.Text.Trim();
            _Person.SecondName = tbSecondName.Text.Trim();
            _Person.ThirdName = tbThirdName.Text.Trim();
            _Person.LastName = tbLastName.Text.Trim();
            _Person.Email = tbEmail.Text.Trim();
            _Person.Phone = tbPhone.Text.Trim();
            _Person.Address = tbAddress.Text.Trim();
            _Person.DateOfBirth = dtpDateOfBirth.Value;
            _Person.Gender = rbMale.Checked ? (byte)0 : (byte)1;

            if(_Person.Save())
            {
                if(_Mode == enMode.Add)
                {
                    MessageBox.Show("Add Successfully with ID: "+_Person.PersonID);

                    if(clsGlobal.CurrentUser != null && clsGlobal.CurrentUser.isAdmin == 1)
                    {
                        frmAddUpdateUserInfo AddNewUser = new frmAddUpdateUserInfo();
                        AddNewUser.ShowDialog();
                        this.ParentForm.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Update Successfully");
                }
            }
        }
    }
}
