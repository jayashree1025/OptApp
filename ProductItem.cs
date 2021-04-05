using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptApp
{
   public class ProductItem
    {
        /// <summary>
        /// The name of the Item
        /// </summary>
        public string ProductCode { get; set; }
        /// <summary>
        /// The name of the Item
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// The name of the Item
        /// </summary>
        public string ProductType { get; set; }

        /// <summary>
        /// The price of the Item
        /// </summary>
        public double Price { get; set; }

        public ProductItem()
        {

        }

        public ProductItem(string ProductCode, string productName, string ProductType, double price)
        {
            this.ProductCode = ProductCode;
            this.ProductType = ProductType;
            this.ProductName = productName;
            this.Price = price; 
        }

       
    }
}
