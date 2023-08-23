using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{

    public class CustomerManager : IInterfaceIntro<Customer>

    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Congrats! " + customer.Name + " added to bank.");
        }


        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.Name + " deleted to bank.");
        }

    }
}