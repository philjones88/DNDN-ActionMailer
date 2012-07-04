using System.Collections.Generic;

namespace DNDN_ActionMailer.MVC3.Models
{
    public class EmailModel
    {
        public class Item
        {
            public int Quantity { get; set; }
            public string Product { get; set; }
            public decimal Price { get; set; }
        }

        public string Title { get; set; }
        public string BirthName { get; set; }
        public string FamilyName { get; set; }
        public string EmailAddress { get; set; }

        public List<Item> PurchasedItems { get; set; }
    }
}