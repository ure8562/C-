using static System.Console;
using System;

namespace StringSlice
{
    class MainApp
    {
        static void Main(string[] args)
        {
            string greeting = "Good morning";

            WriteLine(greeting.Substring(0, 5));    // "Good"
            WriteLine(greeting.Substring(5));       // "Morning"
            WriteLine();

            string[] arr = greeting.Split(
                new string[] { " " }, StringSplitOptions.None); //첫번째 인자 " "도 가능
            WriteLine("Word Count : {0} ", arr.Length);

            foreach(string element in arr)
            {
                WriteLine("{0}", element); 
            }

        }
    }
}
