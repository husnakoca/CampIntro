using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = " Table";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { Id = 2, CategoryId = 5, UnitsInStock = 5, ProductName = "Pencil" , UnitPrice = 35 };

            //case sensitive
            //PascalCase  camelCase
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            //int, decimal, float, double, bool = value type ---> stack ----> sayi1=100 dediği anda sayi1 yerine direkt 100 yazılmış kabl edilir , bellekteki adresle ilgisi yoktur değer çalışır
            //array, class, interface = reference type ---> heap ----> bellekteki adres çalışır önce ref sayi1=50 deyip sonra ref sayi1=35 dersek sonuç 35 olur



        }
    }
}
