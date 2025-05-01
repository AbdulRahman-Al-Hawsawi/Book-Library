using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_Library.Books
{
    public partial class frmBookDetails: Form
    {
        public frmBookDetails(int BookID)
        {
            InitializeComponent();
            _BookID = BookID;
        }

        int _BookID;

        private void frmBookDetails_Load(object sender, EventArgs e)
        {
            ctrBookDetails1.LoadBookDetails(_BookID);
        }
    }
}
