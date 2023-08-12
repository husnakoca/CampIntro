using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace x
{
    public class Class1
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 727772587;
            customer1.Name = "Sarp";
            customer1.Surname = "Palaur";
            customer1.Credit = 1.02;
        }

        static void Delete(Customer customer)
        {
            Console.WriteLine(customer.Name + " " + customer.Surname + "'s record has been deleted successfully.");
        }

        public void Listele(Customer customer)
        {
            Console.WriteLine(customer.Name + " " + "Customer");
            Console.WriteLine(customer.Surname);
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Credit);
        }
    }
}
    
