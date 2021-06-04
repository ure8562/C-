using System;

namespace SignedUnsigned
{
    class MainApp
    {
        static void Main(string[] args)
        {
            byte a = 255;
            sbyte b = (sbyte)a;

            Console.WriteLine($"a={a}");
            Console.WriteLine($"b={b}");
        }
    }
}
