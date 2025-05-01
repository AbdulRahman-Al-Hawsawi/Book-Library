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
using Book_Library.People;

namespace Book_Library.Users
{
    public partial class frmAddNewUser: Form
    {
        public frmAddNewUser()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (clsPerson.isPersonExist(Convert.ToInt32(tbPersonID.Text)))
                ctrPersonDetails1.LoadPersonInfo(Convert.ToInt32(tbPersonID.Text));
            else
            {
                MessageBox.Show("There is no person with this ID");
            }
        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson AddNewPerson = new frmAddUpdatePerson();
            AddNewPerson.ShowDialog();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            frmAddUpdateUserInfo AddNewUser= new frmAddUpdateUserInfo(ctrPersonDetails1.PersonID);
            AddNewUser.ShowDialog();
        }
    }
}