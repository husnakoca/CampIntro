using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class CustomerInfo
    {

        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 7264737;
            customer1.Name = "Sarp";
            customer1.Surname = "Palaur";
            customer1.Credit = 1.02;

            Customer customer2 = new Customer();
            customer2.Id = 2682623929;
            customer2.Name = "Botan";
            customer2.Surname = "Beyaz";
            customer2.Credit = 9.99;

            Customer customer3 = new Customer();
            customer3.Id = 2392;
            customer3.Name = "Bilgin";
            customer3.Surname = "Ozcalkan";
            customer3.Credit = 855;

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            foreach (Customer customer in customers)
            {
                Console.WriteLine("Customer ID: " + customer.Id);
                Console.WriteLine("Customer Name: " + customer.Name);
                Console.WriteLine("Customer Surname: " + customer.Surname);
                Console.WriteLine("Customer Credit: " + customer.Credit);
                Console.WriteLine("------------------------");
            }

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Delete(customer3);

        }
    }
}
