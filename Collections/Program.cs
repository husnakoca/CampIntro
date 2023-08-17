using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names = new string[] {"Engin", "Murat", "Halil", "Kerem" };
            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);
            //Console.WriteLine(names[3]);

            //names = new string[5];
            //names[4] = "Ilker";
            //Console.WriteLine(names[4]);
            //Console.WriteLine(namees[0]);
            //toplu comment almak için ctrl k ctrl c geri almak için ctrl k ctrl u comment uncomment

            List<string> names2 = new List<string> { "Engin", "Murat", "Halil", "Kerem" };
            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
            Console.WriteLine(names2[3]);
            names2.Add("Ilker");
            Console.WriteLine(names2[4]);
            Console.WriteLine(names2[0]);


        }
    }
}
