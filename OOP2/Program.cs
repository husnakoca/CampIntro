using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Engin Demiroğ
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.Number = "44444";
            customer1.Name = "Engin";
            customer1.Name = "Demiroğ";
            customer1.Name = "27272727272";

            //Kodlama.io
            CoorporateCustomer customer2 = new CoorporateCustomer();
            customer2.Id = 2;
            customer2.Number = "55555";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNumber = "9797979797";

            IndividualCustomer customer3 = new IndividualCustomer();
            CoorporateCustomer customer4 = new CoorporateCustomer();
            

            //Coorporate Customer - Individual Customer
            //SOLID --> L
        }
    }
}
