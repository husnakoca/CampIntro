using System;

namespace ConsoleApp3
{
    class FileLoggerServices : ILoggerService

    {
        public void Log()
        {
            Console.WriteLine("Logged to the file.");

        }
    }
}
