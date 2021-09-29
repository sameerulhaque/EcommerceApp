 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Configuration;

namespace Commons.Utils
{
   public class EmailSender
    {

        //private static string emailAddressFrom = System.Configuration.ConfigurationManager.AppSettings["EmailAddress"].ToString();
        //private static string emailAddressPassword = System.Configuration.ConfigurationManager.AppSettings["Password"].ToString();
        //private static int smtpPort = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["PortAddress"].ToString());
        //private static string smtpClient = System.Configuration.ConfigurationManager.AppSettings["smtpClient"].ToString();

        //public string sendEmail(string emailAddress, string subject, string msg)
        //    {
        //    try
        //    {
        //        MailMessage mail = new MailMessage();
        //        SmtpClient SmtpServer = new SmtpClient(smtpClient, smtpPort);

        //        mail.From = new MailAddress(emailAddressFrom,"Account Validation");
        //        mail.To.Add("sameer.ulhaq79@gmail.com");
        //        mail.CC.Add("Sameer.ulhaq79@gmail.com");
                
        //        mail.Subject = subject;
        //        mail.Body = msg;
        //        mail.IsBodyHtml = true;
        //        mail.Priority = MailPriority.High;
        //        mail.BodyEncoding = Encoding.UTF8;

      
        //        SmtpServer.Credentials = new System.Net.NetworkCredential(emailAddressFrom, emailAddressPassword);
        //        SmtpServer.EnableSsl = true;
        //        Thread mail_thread = new Thread(delegate ()
        //            {

        //                SmtpServer.Send(mail);
        //            });

        //        mail_thread.Start();
        //        return "true";
        //    }
        //    catch (Exception ex)
        //    {
        //        return  ex.Message + "inner exeption: "  + ex.InnerException.Message.ToString();
        //    }
        //}

    }
  
}
