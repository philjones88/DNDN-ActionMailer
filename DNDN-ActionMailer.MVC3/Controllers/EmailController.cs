using ActionMailer.Net.Mvc;
using DNDN_ActionMailer.MVC3.Models;

namespace DNDN_ActionMailer.MVC3.Controllers
{
    public class EmailController : MailerBase
    {
        public EmailResult SimpleEmail()
        {
            From = "phil@example.org";
            To.Add("bob@example.org");
            Subject = "Hello ActionMailer World!";

            return Email("SimpleEmail");
        }

        public EmailResult TypedEmail(EmailModel model)
        {
            From = "phil@example.org";
            To.Add(model.EmailAddress);
            Subject = string.Format("Thanks {0} for your purchases", model.BirthName);

            return Email("TypedEmail", model);
        }
    }
}
