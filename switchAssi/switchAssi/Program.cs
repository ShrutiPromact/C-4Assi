using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchAssi
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Product> productList = new List<Product>() {
                new Product(){ pName="lettuce", price=10.5f, quantity=50,type="Leafy green"},
                new Product(){ pName="cabbage", price=20, quantity=100,type="Cruciferous"},
                new Product(){ pName="pumpkin", price=30, quantity=30,type="Marrow"},
                new Product(){ pName="cauliflower", price=10, quantity=25,type="Cruciferous"},
                new Product(){ pName="zucchini", price=20.5f, quantity=50,type="Marrow"},
                new Product(){ pName="yam", price=30, quantity=50,type="Root"},
                new Product(){ pName="spinach", price=10, quantity=100,type="Leafy green"},
                new Product(){ pName="broccoli", price=20.2f, quantity=75,type="Cruciferous"},
                new Product(){ pName="Garlic", price=30, quantity=20,type="Leafy green"},
                new Product(){ pName="silverbeet", price=10, quantity=50,type="Marrow"},
            };


            Console.WriteLine("Which type of product you want?");
            string val = Console.ReadLine();

            void check()
            {
                var s = productList.Where(x => x.type == val);
                foreach (Product item in s)
                {
                    Console.WriteLine("Name: " + item.pName + " " + " price: " + item.price + " " + " quantity:" + " " + item.quantity);
                }
            }

            switch (val)
            {
                case "Leafy green":
                    check();
                    break;

                case "Cruciferous":
                    check();
                    break;

                case "Marrow":
                    check();
                    break;

                default:
                    Console.WriteLine("Default case");
                    break;
            }
            Console.WriteLine();
            float Tprice = 0;

            foreach (Product item in productList)
            {
                Tprice = Tprice + (item.price * item.quantity);

            }
            //Console.WriteLine(" price: " + item.price + " " + " quantity:" + " " + item.quantity);
            Console.WriteLine("total price of whole Inventory is including the quantities of products is = " + Tprice);
            Console.WriteLine();

            float average = Tprice / productList.Count;
            Console.WriteLine("Average of total price is =" + average);
            Console.WriteLine();



            Console.WriteLine("Which type of product you want?");
            string write = Console.ReadLine();
            switch (write)
            {
                case "costly":
                    checkprice();
                    break;

                case "cheep":
                    checkprice();
                    break;

                default:
                    Console.WriteLine("Default case");
                    break;
            }

            void checkprice()
            {
                //var s = productList.Where(x => x.price == write);
                foreach (Product item in productList)
                {
                    if (item.price * item.quantity > 50)
                        Console.WriteLine("Costly product is :--Name: " + item.pName + " " + " price: " + item.price + " " + " quantity:" + " " + item.quantity);
                    else
                        Console.WriteLine("Cheep product is :---Name: " + item.pName + " " + " price: " + item.price + " " + " quantity:" + " " + item.quantity);
                }

                Console.ReadKey();
            }
        }
    }
}
