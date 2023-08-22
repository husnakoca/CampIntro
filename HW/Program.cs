using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    internal class Program
        {
            static void Main(string[] args)
            {
                MyDictionarys<int, string> myDictionarys = new MyDictionarys<int, string>();
                myDictionarys.Add(1, "one");
                myDictionarys.Add(2, "two");
                myDictionarys.Add(3, "three");

                Console.WriteLine("Number of Elements: " + myDictionarys.Lenght());
                myDictionarys.Yazdır();
                myDictionarys.Yazdır2();
                myDictionarys.VeriyiCek(1);
                myDictionarys.VeriyiCek(4);

            }
        }
    }

