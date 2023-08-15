using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    public class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Congrats! Added to bank. : " + customer.Name);
            Console.ReadLine();

        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Congrats! The customer deleted to bank: " + customer.Name);
            Console.ReadLine();

        }
    }
}