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
using Book_Library.GlobalClasses;
using Book_Library.Properties;

namespace Book_Library.Users
{
    public partial class ctrUserInfo: UserControl
    {
        public ctrUserInfo()
        {
            InitializeComponent();
        }

        public void LoadInfo()
        {
            //clsUser User = clsUser.Find(UserID);

            if (clsGlobal.CurrentUser.PersonInfo.Gender == 0)
            {
                pbPersonImage.Image = Resources.person_man;
            }
            else
                pbPersonImage.Image = Resources.person_woman;

            lblUsername.Text = clsGlobal.CurrentUser.Username;
            lblUserID.Text = clsGlobal.CurrentUser.UserID.ToString();
        }

        private void ctrUserInfo_Load(object sender, EventArgs e)
        {
            LoadInfo();
        }
    }
}
