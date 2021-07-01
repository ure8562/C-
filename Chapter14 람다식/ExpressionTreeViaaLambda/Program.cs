using System;
using System.Linq.Expressions;

namespace ExpressionTreeViaaLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Expression<Func<int, int, int>> expression =
                (a, b) => 1 * 2 + (a - b);
            Func<int, int, int> func = expression.Compile();

            Console.WriteLine($"1*2+({7}-{8}) = {func(7, 8)}");
        }
    }
}
