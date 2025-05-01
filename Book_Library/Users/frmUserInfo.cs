using Book_Library.GlobalClasses;
using Book_Library.People;
using System;
using System.CodeDom.Compiler;
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
    public partial class frmUserInfo: Form
    {
        public frmUserInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
        }

        public delegate void DataBackEventHandler();
        public event DataBackEventHandler Logout;

        void ShowUserDetails()
        {
            frmPersonDetails PersonDetails = new frmPersonDetails(clsGlobal.CurrentUser.PersonInfo.PersonID);
            PersonDetails.Show();
        }
        private void tvNavigationOptions_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (e.Node.Text)
            {
                case "Me":
                    ShowUserDetails();
                    break;
            }
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
            Logout.Invoke();
        }
    }
}
