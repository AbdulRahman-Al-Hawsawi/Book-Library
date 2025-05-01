using Book_Library.GlobalClasses;
using System;
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
    public partial class frmConfirmEmail: Form
    {
        public frmConfirmEmail(string Email)
        {
            InitializeComponent();
           // _SentCode = SentCode;
           _Email = Email;
        }

        string _SentCode;
        string _Email;

        public delegate void DataBackEventHandler(bool IsMatching);
        public event DataBackEventHandler ReturnTheMatchResult;

        void SendMessageToConfirmEmail()
        {
            string TheCode = clsUtil.GenerateRandomNumber(6);
            _SentCode = TheCode;

            if (clsUtil.SendEmail("Abdu75p@gmail.com", _Email, "Email Verification", "Your verification code is: " + TheCode))
            {
                MessageBox.Show("Code is sent check your Email");
            }
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(_SentCode == tbSentCode.Text)
            {
                ReturnTheMatchResult(true);
                MessageBox.Show("Verified");
                this.Close();
            }
            else
            {
                errorProvider1.SetError(tbSentCode, "Not matched");
            }
            //else
            //    ReturnTheMatchResult(false);
        }

        private void btnResend_Click(object sender, EventArgs e)
        {
            SendMessageToConfirmEmail();
        }

        private void frmConfirmEmail_Load(object sender, EventArgs e)
        {
            SendMessageToConfirmEmail();
        }

        private void frmConfirmEmail_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void tbSentCode_Enter(object sender, EventArgs e)
        {
               
            if (tbSentCode.Text == "Enter The Code Here")
                tbSentCode.Text = "";
        }

        private void tbSentCode_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tbSentCode.Text))
                tbSentCode.Text = "Enter The Code Here";

        }

        private void btnCheckEmail_Click(object sender, EventArgs e)
        {
            ReturnTheMatchResult(false);
            this.Close();   
        }
    }
}
