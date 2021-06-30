using System;

namespace StatementLambda
{
    delegate string Concatenate(string[] arg);
    class Program
    {
        static void Main(string[] args)
        {
            Concatenate concat =
                (arr) =>
                {
                    string result = "";
                    foreach (string s in arr)
                    {
                        result += s;
                    }
                    return result;
                };
            Console.WriteLine(concat(args));
        }
    }
}
