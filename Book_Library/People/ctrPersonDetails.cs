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

namespace Book_Library.People
{
    public partial class ctrPersonDetails: UserControl
    {
        public ctrPersonDetails()
        {
            InitializeComponent();
        }
        int _PersonID;
        public int PersonID
        {
            get { return _PersonID; }
            set { _PersonID = value; }
        }

        public void LoadPersonInfo(int PersonID)
        {
            clsPerson Person = clsPerson.Find(PersonID);
            _PersonID = PersonID;
            lblPersonID.Text = PersonID.ToString();
           // lblNationalNo.Text = Person.NationalNo;
            lblName.Text = Person.FullName;
            lblGender.Text = Person.Gender == 0? "Male": "Female";
            lblDateOfBirth.Text = Person.DateOfBirth.ToShortDateString();
            lblEmail.Text = Person.Email;
            lblPhone.Text = Person.Phone;
            lblAddress.Text = Person.Address;
           // lblCountry.Text = clsCountry.GetCountry(Person.CountryID);
           ChoseGenderImage(Person.Gender);
        }

        void ChoseGenderImage(byte Gender)
        {
            if (Gender == 0)
                pbPersonImage.Image = Resources.person_man;
            else
                pbPersonImage.Image = Resources.person_woman;
        }

        private void llblEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddUpdatePerson UpdatePerson = new frmAddUpdatePerson(_PersonID);
            UpdatePerson.ShowDialog();
            LoadPersonInfo(_PersonID);
        }
    }
}
