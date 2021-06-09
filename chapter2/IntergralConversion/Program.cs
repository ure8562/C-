using System;

namespace IntegralConversion
{
    class MainApp
    {
        static void Main(string[] args)
        {
            sbyte a = 127;
            Console.WriteLine(a);

            int b = (int)a;
            Console.WriteLine(b);

            int x = 128;
            Console.WriteLine(x);

            int y = (sbyte)x;       //오버플로우(overflow) 발생
            Console.WriteLine(y);

        }
    }
}
