using System;

namespace GenericDelgate
{
    delegate int Compare<T>(T a, T b);

    class Program
    {
        static int AscendCompare<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b);
        }
        static int DescendCompare<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b) * -1;
        }

        static void BubbleSort<T>(T[] DataSet, Compare<T> comparer)
        {
            int i = 0;
            int j = 0;
            T temp;

            for (i = 0; i < DataSet.Length - 1; i++)
            {
                for (j = 0; j < DataSet.Length - (i + 1); j++)
                {
                    if (comparer(DataSet[j], DataSet[j + 1]) > 0)
                    {
                        temp = DataSet[j + 1];
                        DataSet[j + 1] = DataSet[j];
                        DataSet[j] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int[] array = { 3, 7, 4, 2, 10 };

            Console.WriteLine("Sorting ascending");
            BubbleSort<int>(array, new Compare<int>(AscendCompare));

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }

            string[] array2 = { "abc", "def", "ghi", "jkl", "mno" };

            Console.WriteLine("\nSorting descending...");
            BubbleSort(array2, new Compare<string>(DescendCompare));

            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write($"{array2[i]} ");
            }

            Console.WriteLine();
        }
    }
}
