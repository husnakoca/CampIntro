using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string productName = "Apple";
            int price = 10;
            string explanation = "Heaven's Apple";

            string[] fruits = new string[] { };

            Product product1 = new Product();
            product1.Name = "Apple";
            product1.Price = 10;
            product1.Explanation = "Heaven's Apple";

            Product product2 = new Product();
            product2.Name = "Strawberries";
            product2.Price = 20;
            product2.Explanation = "Pink Grave's Strawberries";

            //array means structure that holding the data

            Product[] products = new Product[] { product1, product2 };

            foreach (var product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Explanation);
                Console.WriteLine("--------------------");

            }

           //cw tab tab
            Console.WriteLine("------------------Methods------------");

            //instance - example
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);

            sepetManager.Add2("Pear", "Green Pear", 35, 265);
            sepetManager.Add2("Watermelon", "Nice Watermelon", 100, 258);
            sepetManager.Add2("Banana", "Sweet Banana", 70, 569);
        }
    }
}

//do not repeat yourself - DRY - Clean Code - best practice