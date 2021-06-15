using System;

namespace DeepCopy
{
    class MyClass
    {
        public int MyField1;
        public int Myfield2;

        public MyClass DeepCopy()
        {
            MyClass newCopy = new MyClass();
            newCopy.MyField1 = this.MyField1;
            newCopy.Myfield2 = this.Myfield2;

            return newCopy;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shallow Copy");

            {
                MyClass source = new MyClass();
                source.MyField1 = 10;
                source.Myfield2 = 20;

                MyClass target = source;
                target.Myfield2 = 30;

                Console.WriteLine($"{source.MyField1} {source.Myfield2}");
                Console.WriteLine($"{target.MyField1} {target.Myfield2}");
            }

            Console.WriteLine("Deep Copy");

            {
                MyClass source = new MyClass();
                source.MyField1 = 10;
                source.Myfield2 = 20;

                MyClass target = source.DeepCopy();
                target.Myfield2 = 30;

                Console.WriteLine($"{source.MyField1} {source.Myfield2}");
                Console.WriteLine($"{target.MyField1} {target.Myfield2}");
            }
        }
    }
}
