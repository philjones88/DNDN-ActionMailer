using System.Net.Mail;

namespace DNDN_ActionMailer
{
    public class BadEmailer
    {
        public void Send()
        {
            // THIS IS BAD STUFF
            var message = new MailMessage();

            message.To.Add("bob@example.org");
            message.Subject = "Hello World";
            message.From = new MailAddress("phil@example.org");
            message.Body = "<h1>Hello World!</h1>";
            message.IsBodyHtml = true;

            var smtp = new SmtpClient();

            smtp.Send(message);
        }
    }
}
