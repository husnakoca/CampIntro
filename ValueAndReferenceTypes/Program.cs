﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 30;
            number1 = number2;
            number2 = 65;
            //number1 ?? 30 

            int[] numbers1 = new int[] { 10, 20, 30 };
            int[] numbers2 = new int[] { 100, 200, 300};
            numbers1 = numbers2;
            numbers2[0] = 999;
            //numbers1[0]?? 999
            //int, decimal, float, double, bool = value type ---> stack ----> sayi1=sayi2 dediği anda 10 gider 30 olur , sayi2 65 olunca 30 gider 65 olur ama bunun sayi1 ile hiçbir bağı olmaz
            //array, class, interface = reference type ---> heap
        }
    }
}
