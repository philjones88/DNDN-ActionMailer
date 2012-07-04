using System;
using System.IO;
using ActionMailer.Net.Standalone;
using DNDN_ActionMailer.Standalone.Models;

namespace DNDN_ActionMailer.Standalone
{
    public class EmailService : RazorMailerBase
    {
        private readonly string _viewPath;

        public override string ViewPath
        {
            get { return _viewPath; }
        }

        public EmailService()
        {
            From = "phil@example.org";
            To.Add("bob@example.org");

            _viewPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..", "EmailTemplates");
        }

        public RazorEmailResult Simple()
        {
            Subject = "Hello From Console App Land!";

            return Email("Simple");
        }

        public RazorEmailResult Typed(EmailModel model)
        {
            From = "phil@example.org";
            To.Add(model.EmailAddress);

            Subject = string.Format("Thanks {0} for your purchases", model.BirthName);

            return Email("Typed", model);
        }

        public RazorEmailResult Multipart(EmailModel model)
        {
            From = "phil@example.org";
            To.Add(model.EmailAddress);

            Subject = string.Format("Thanks {0} for your purchases", model.BirthName);

            return Email("Multipart", model);
        }

        public RazorEmailResult TypedBroken(EmailModel model)
        {
            From = "phil@example.org";
            To.Add(model.EmailAddress);

            Subject = string.Format("Thanks {0} for your purchases", model.BirthName);

            return Email("TypedBroken", model);
        }
    }
}
