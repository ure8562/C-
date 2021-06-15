using System;

namespace SealedMethod
{
    class Base
    {
        public virtual void SealMe()
        {

        }
    }
    class Derived : Base
    {
        public sealed override void SealMe()
        {
        }
    }
    class test : Base
    {
        public override void SealMe()
        {
        }
    }
    class derived_test : test
    {
        public override void SealMe()
        { }
    }
    class WantToOverried : Derived
    {
        public override void SealMe() 
        { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
