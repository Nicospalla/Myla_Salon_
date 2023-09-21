using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Accesorios
{

    public class EmailServices
    {
        private SmtpClient smtpClient;
        private MailMessage email;

        public EmailServices() 
        {
            smtpClient = new SmtpClient();
            smtpClient.Credentials = new NetworkCredential("itdevspa@gmail.com", "yqfr hcqo bzwj jpoo");
            smtpClient.EnableSsl = true;
            smtpClient.Port = 587;
            smtpClient.Host = "smtp.gmail.com";
        }
        public async void armarCorreo(string emailDestino, string asunto, string filePath = "", string cuerpo = "")
        {
            email = new MailMessage();
            email.From = new MailAddress("itdevspa@gmail.com", "itdevspa@gmail.com");
            email.To.Add(emailDestino);
            email.Subject = asunto;
            email.Body = cuerpo;
            if(filePath != "")
            {
                Attachment file = new Attachment(filePath);
                email.Attachments.Add(file);
                await Task.Yield();

            }

        }
        public void enviarMail()
        {
            try
            {
                smtpClient.Send(email);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
