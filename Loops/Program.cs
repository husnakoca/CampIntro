using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //array
            string[] courses = new string[] { "Software developer training camp", "Basic course for introductory programming", "Java", "Python" };

            for (int i = 0; i<courses.Length; i++)
            {
                Console.WriteLine(courses[i]);
            }

            Console.WriteLine("And of the for");

            foreach (string course in courses)
            {
                Console.WriteLine(course);
            }
            //course is alias in here

            Console.WriteLine("And of the page. - foooter");
        }
    }
}
