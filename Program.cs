using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductInStock pstock = new ProductInStock();
            ProductItem[] pitem = new ProductItem[9];
            

            pitem[0] = new ProductItem("1", "Potato Chip", "Chip", 3.05);
            pitem[1] = new ProductItem("2", "Banana Chip", "Chip", 0.85);
            pitem[2] = new ProductItem("3", "Potato & Tomato Chip", "Chip", 2.75);
            pitem[3] = new ProductItem("4", "white chocolate", "Candy", 1.8);
            pitem[4] = new ProductItem("5", "Carboury", "Candy", 1.5);
            pitem[5] = new ProductItem("6", "Kit-Kat", "Candy", 1.5);
            pitem[6] = new ProductItem("7", "Coca Cola", "Cola", 1.5);
            pitem[7] = new ProductItem("8", "Pepsi ", "Cola", 1.5);
            pitem[8] = new ProductItem("9", "Fanta", "Cola", 1.55);

            MoneyInfo[] moneyInfos = new MoneyInfo[3];
            moneyInfos[0] = new MoneyInfo(5, 2);
            moneyInfos[1] = new MoneyInfo(10, 4);
            moneyInfos[2] = new MoneyInfo(25, 8);

            int resultValue;
            Console.WriteLine("Welcome To Vending Zone:");

            Console.WriteLine("Please put Coin , Allowed {5(Nickel),10(Nickel),25(Nickel)}");


            double money = 0;

            while (true)
            {
                string getUserInput = Console.ReadLine();

                if (getUserInput == "5" || getUserInput == "10" || getUserInput == "25")
                {
                    money += Double.Parse(getUserInput);

                    Console.WriteLine("Do you want to Add more {Y/N} ?");
                    string temp = Console.ReadLine();
                    if (temp == "Y")
                    {
                        Console.WriteLine("Toal Coin Received " + money);
                        Console.WriteLine("Please put Coin , Allowed {5,10,25}");
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Coin, Please enter a valid coin!");
                    Console.WriteLine("Please put Coin , Allowed {5,10,25}");
                    continue;
                }

            }
          
            Console.Write("Please Select an Item ");
            pstock.DisplayAllItems(pitem);

            
            string getProductInput = Console.ReadLine();
            var productIndex = -1;
            for (int i = 0; i < pitem.Length; i++)
            {
                if(pitem[i].ProductCode == getProductInput)
                {
                    productIndex = i;
                }
               
            }
            if(productIndex >= 0)
            {
                if(pitem[productIndex].Price <= money)
                {
                    Console.WriteLine("Coin Received" + money);
                    Console.WriteLine("Product Price" + pitem[productIndex].Price);
                    Console.WriteLine("Coin Returned" + (money- pitem[productIndex].Price));
                    Console.WriteLine("Oredr has delivered, Thank you");

                }
                else
                {
                    Console.WriteLine("Product Price higher than coin entered");
                }

            }       

            else
            {
                Console.WriteLine("Invalid Item code!");
            }
           
            Console.ReadKey();

        }

    }

   
}
