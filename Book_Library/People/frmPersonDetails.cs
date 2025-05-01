using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Library.People
{
    public partial class frmPersonDetails: Form
    {
        public frmPersonDetails(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;   
        }
        int _PersonID;

        private void frmPersonDetails_Load(object sender, EventArgs e)
        {
            ctrPersonDetails1.LoadPersonInfo(_PersonID);
        }
    }
}
