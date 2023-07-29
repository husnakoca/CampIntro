using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class SepetManager
    {
        //naming convention
        //syntax
        public void Add(Product product)
        {
            Console.WriteLine("Congrats! Added to cart. : " + product.Name);

        }

        public void Add2(string productName, string explanation, double price,  int numberofitem)
        {
            Console.WriteLine("Congrats! Added to cart. : " + productName);
        }
    }
}
