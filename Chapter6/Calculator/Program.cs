using System;

namespace Method
{
    class Calculator
    {
        public static int Puls(int a, int b)
        {
            return a + b;
        }

        public int Minus(int a, int b)
        {
            return a - b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator Cal = new Calculator();
            int result = Calculator.Puls(3, 4);
            Console.WriteLine(result);

            result = Cal.Minus(5, 2);
            Console.WriteLine(result);
        }
    }
}
