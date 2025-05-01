using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Book_Library.GlobalClasses;

namespace Book_Library
{
    public partial class frmTest: Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show( clsUtil.GenerateRandomNumber(6));
            dataGridView1.DataSource = clsGlobal.GetAllApplicationEventLogs();
        }
    }
}
