using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webform1
{
    public partial class sentEmail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void SendMail()
        {
            MailMessage mail = new MailMessage();
            mail.To.Add(TextBox1.Text);
            mail.From = new MailAddress("brindageorge94@gmail.com");
            mail.Subject = "open";
            string Body = "haiiiiiii....";
            mail.Body = Body;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential("brindageorge94", "password");
            smtp.EnableSsl = true;
            smtp.Send(mail);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SendMail();
        }
    }
}