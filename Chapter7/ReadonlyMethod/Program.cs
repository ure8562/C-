using System;

namespace ReadonlyMethod
{
    struct ACSetting
    {
        public double currenInCelsius;
        public double target;
        public readonly double GetFahrenheit()
        {
            target = currenInCelsius * 1.8 + 32;
            return target;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ACSetting acs;
            acs.currenInCelsius = 25;
            acs.target = 25;

            Console.WriteLine($"{acs.GetFahrenheit()}");
            Console.WriteLine($"{acs.target}");
        }
    }
}
