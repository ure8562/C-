using System;
using static System.Console;

namespace chapter2
{
    class MainApp
    {
        static void Main(string[] args)
        {
            //프로그램 시작부
            if (args.Length == 0)
            {
                Console.WriteLine("사용법 : Hello.exe <이름>");
                return;
            }

            WriteLine("hello, {0}!", args[0]);
        }
        
    }
}
