using System;

namespace _3DArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] array = new int[4, 3, 2]
            {
                {{1,2},{3,4},{5,6} },
                {{1,4},{2,5},{3,6} },
                {{1,2},{3,4},{5,6} },
                {{1,2},{3,4},{5,6} }
            };

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("{ ");
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        Console.Write($"{array[i, j, k]} ");
                    }
                    Console.Write(" }");
                }
                Console.WriteLine();
            }
        }
    }
}
