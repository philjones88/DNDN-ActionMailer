using System.Collections.Generic;
using System.Web.Mvc;
using DNDN_ActionMailer.MVC3.Models;

namespace DNDN_ActionMailer.MVC3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SendSimpleEmail()
        {
            new EmailController().SimpleEmail().Deliver();

            return View("Index");
        }

        public ActionResult SendTypedEmail()
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

            new EmailController().TypedEmail(model).Deliver();

            return View("Index");
        }
    }
}
