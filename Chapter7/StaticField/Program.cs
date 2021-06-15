using System;

namespace StaticField
{
    class Grobal
    {
        public static int Count = 0;
    }

    class ClassA
    {
        public ClassA()
        {
            Grobal.Count++;
        }
    }

    class ClassB
    {
        public ClassB()
        {
            Grobal.Count++;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Grobal.Count : {Grobal.Count}");

            new ClassA();
            new ClassA();
            new ClassB();
            new ClassB();
            
            Console.WriteLine($"Grobal.Count : {Grobal.Count}");

        }
    }
}
