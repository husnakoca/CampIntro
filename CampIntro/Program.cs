using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety
            //do not repeat yourself -DRY - best practice -clean code
            //alias = değer tutucu
            Console.WriteLine("Hello World!");

            String CategoryLabel = "Kategori Etiketi";
            int NumberofStudent = 32000;
            double rate = 1.27;
            bool IsSheLoggedIntoTheSystem = false;
            double DollarYesterday = 1.42;
            double DollarToday = 2.56;

            if (DollarYesterday>DollarToday)
            {
                Console.WriteLine("Descreasing Symbol");
            }
            else if (DollarYesterday < DollarToday)
            {
                Console.WriteLine("Increasing Symbol");
            }
            else
            {
                Console.WriteLine("Equal Symbol");
            }
            //if tabtab
            if (IsSheLoggedIntoTheSystem == true)
            {
                Console.WriteLine("User Settings");

            }
            else
            {
                Console.WriteLine("Log In Button");
            }

        }
    }
}
