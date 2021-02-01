using System;
using System.Linq;

namespace _01.SumMatrixElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] countRowsAndCols = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int[,] matrix = new int[countRowsAndCols[0],countRowsAndCols[1]];


            int sum = 0;

            for (int i = 0; i < countRowsAndCols[0]; i++)
            {
                int[] arr = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int j = 0; j < countRowsAndCols[1]; j++)
                {
                    matrix[i,j] = arr[j];
                    sum += arr[j];
                }
            }
            Console.WriteLine(countRowsAndCols[0]);
            Console.WriteLine(countRowsAndCols[1]);
            Console.WriteLine(sum);
        }
    }
}
