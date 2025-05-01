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
    public partial class frmAddUpdatePerson: Form
    {
        public frmAddUpdatePerson()
        {
            InitializeComponent();
        }

        public frmAddUpdatePerson(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;   
        }

        public delegate void DataBackEventHandler(int PersonID);
        public event DataBackEventHandler DataBack;


        int _PersonID =-1;
        private void frmAddUpdatePerson_Load(object sender, EventArgs e)
        {
            ctrAddUpdatePerson1.LoadPersonInfo(_PersonID);
        }

        private void ctrAddUpdatePerson1_Load(object sender, EventArgs e)
        {

        }
    }
}
