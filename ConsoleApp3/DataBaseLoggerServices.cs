using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class DataBaseLoggerServices : ILoggerService

    {
        public void Log()
        {
            Console.WriteLine("Logged to database.");

        }
    }
}
