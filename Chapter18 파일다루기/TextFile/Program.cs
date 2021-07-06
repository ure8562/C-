using System;
using System.IO;

namespace TextFile
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter sw = new StreamWriter(new FileStream("a.txt", FileMode.Create)))
            {
                sw.WriteLine(int.MaxValue);
                sw.WriteLine("Good Morning");
                sw.WriteLine(uint.MaxValue);
                sw.WriteLine("안녕하세요");
                sw.WriteLine(double.MaxValue);
            }

            using (StreamReader sr = new StreamReader(new FileStream("a.txt", FileMode.Open)))
            {
                Console.WriteLine($"File size : {sr.BaseStream.Length} bytes");

                while (sr.EndOfStream == false)
                {
                    Console.WriteLine(sr.ReadLine());
                }
            }
        }
    }
}
