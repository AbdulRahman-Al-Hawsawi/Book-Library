using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Book_Library.GlobalClasses
{
    public class clsUtil
    {
         public static bool SendEmail(string To,string Subject,string Body)
        {
            return SendEmail(ConfigurationManager.AppSettings["ApplicationEmail"], To, Subject, Body);
        }

        public static bool SendEmail(string From , string To,string Subject,string Body)
        {
           bool Result=false;
            try
            {
              

                // Create a new MailMessage object
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(From);
                mail.To.Add(To);
                mail.Subject = Subject;
                mail.Body = Body;

                // Set up the SMTP client
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                smtpClient.Port = 587;  // Common SMTP port (use 465 for SSL)
                smtpClient.Credentials = new NetworkCredential(From, ConfigurationManager.AppSettings["ApplicationEmailPassword"] /*"bjlt hqdj uxhn liqi"*/);
                smtpClient.EnableSsl = true; // Enable SSL
                smtpClient.Timeout = 30000;

                // Send the email
                smtpClient.Send(mail);
                Result = true;  
               // MessageBox.Show("Email sent successfully!");
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error: " + ex.Message);
                Result =  false;
            }
            return Result;
        }

        public static string GenerateRandomNumber(int length)
        {
            Random random = new Random();
            StringBuilder Number = new StringBuilder() ;
            for (int i = 0; i < length; i++)
            {
                Number.Append(random.Next(1, 10));
            }
            return Number.ToString();
        }
    }
}
