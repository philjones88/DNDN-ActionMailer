using System.Collections.Generic;
using DNDN_ActionMailer.Standalone.Models;

namespace DNDN_ActionMailer.Standalone
{
    class Program
    {
        public static void Simple()
        {
            new EmailService().Simple().Deliver();
        }

        public static void Typed()
        {
            var model = new EmailModel
            {
                Title = "Mr",
                BirthName = "Phil",
                FamilyName = "Jones",
                EmailAddress = "phil@example.org",
                PurchasedItems = new List<EmailModel.Item>
                {
                    new EmailModel.Item { Quantity = 2, Product = "Foo", Price = (decimal) 12.99 },
                    new EmailModel.Item { Quantity = 10, Product = "Bar", Price = (decimal) 24.99 }
                }
            };

            new EmailService().Typed(model).Deliver();
        }

        public static void Multipart()
        {
            var model = new EmailModel
            {
                Title = "Mr",
                BirthName = "Phil",
                FamilyName = "Jones",
                EmailAddress = "phil@example.org",
                PurchasedItems = new List<EmailModel.Item>
                {
                    new EmailModel.Item { Quantity = 2, Product = "Foo", Price = (decimal) 12.99 },
                    new EmailModel.Item { Quantity = 10, Product = "Bar", Price = (decimal) 24.99 }
                }
            };

            new EmailService().Multipart(model).Deliver();
        }

        static void Main(string[] args)
        {
            //Simple();

            //Typed();

            Multipart();
        }
    }
}
