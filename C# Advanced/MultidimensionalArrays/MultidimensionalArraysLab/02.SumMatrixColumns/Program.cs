using System;
using System.Linq;

namespace _02.SumMatrixColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] countRowsAndCOls = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int rows = countRowsAndCOls[0];
            int cols = countRowsAndCOls[1];

            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                int[] currentRow = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = currentRow[j];
                }
            }
            for (int i = 0; i < cols; i++)
            {
                int sum = 0;
                //1 3 3 2 1
                //1 3 9 8 5 6
                //4 6 7 9 1 0

                for (int j = 0; j < rows; j++)
                {
                    sum += matrix[j,i];
                }
                Console.WriteLine(sum);
            }
        }
    }
}
