using System;
using static System.Console;

namespace chapter2
{
    class MainApp
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Hello World!");
                return;
            }

            WriteLine("hello, {0}!", args[0]);
        }
        
    }
}
