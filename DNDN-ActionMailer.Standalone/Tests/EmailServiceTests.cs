using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DNDN_ActionMailer.Standalone.Models;
using NUnit.Framework;

namespace DNDN_ActionMailer.Standalone.Tests
{
    [TestFixture]
    public class EmailServiceTests
    {
        private EmailService _service;

        [SetUp]
        public void SetUp()
        {
            _service = new EmailService();
        }

        [Test]
        public void ShowOffCompilingRazorTemplatesThatFail()
        {
            var expected = new EmailModel
            {
                Title = "Mr",
                BirthName = "Bob",
                FamilyName = "Smith",
                EmailAddress = "bob@example.org",
                PurchasedItems = new List<EmailModel.Item>
                {
                    new EmailModel.Item { Quantity = 2, Product = "Foo", Price = (decimal) 12.99 },
                    new EmailModel.Item { Quantity = 10, Product = "Bar", Price = (decimal) 24.99 }
                }
            };

            var actual = _service.TypedBroken(expected);

            actual.Compile(expected);

            Assert.AreEqual("Thanks Bob for your purchases", actual.Mail.Subject);
        }
    }
}
