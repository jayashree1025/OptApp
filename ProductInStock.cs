using System;
using System.Collections.Generic;
using System.Text;

namespace OptApp
{
   public class ProductInStock
    {
        private Logger Log = new Logger();
        public Dictionary<string, ProductItem> productItems = new Dictionary<string, ProductItem>();
       
       // public Money Money { get; }
        public string NotEnoughMoneyError = "Not enough money in the machine to complete the transaction.";
        public string MessageToUser;
        public ProductInStock()
        {
            
           // this.Money = new Money(this.Log);

        }
        public void DisplayAllItems(ProductItem[] pitem)
        {
            Console.WriteLine($"\n\n{"#".PadRight(5)} {"ProductCode"} { "ProductName".PadRight(47) } { "Price".PadLeft(7)}");
            for (int i = 0; i < pitem.Length; i++)
            {
                string ProductCode = pitem[i].ProductCode.PadRight(5);
                string productName = pitem[i].ProductName.PadRight(40);
                string price = pitem[i].Price.ToString("C").PadLeft(7);
                Console.WriteLine($"{ProductCode} {productName} Costs: {price} each");
            }
        }
        public bool ItemExists(string itemNumber)
        {
            return this.productItems.ContainsKey(itemNumber);
        }
       
    }
}