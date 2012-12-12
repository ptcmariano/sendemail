using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;

namespace MgSendEmail
{
    class SendEmail
    {
        public void MgSendEmail(string user, string pass,
								string from, string to, 
								string subject, string message, 
								string server, int port)
        {
            SmtpClient client = new SmtpClient();
            client.Host = server;
            client.Port = port;
            client.EnableSsl = true;
            System.Net.NetworkCredential nc = new System.Net.NetworkCredential(user, pass);
            client.Credentials = nc;
            try
            {
                MailMessage msg = new MailMessage();
                msg.From = new MailAddress(from);
                msg.To.Add(to);
                msg.Subject = subject;
                msg.Body = message;
                client.Send(msg);
            }
            catch (FormatException f)
            {
                Console.WriteLine("Erro de formato dos endereços: " + f);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao enviar email: "+e);
            }
            
        }
    }
}
