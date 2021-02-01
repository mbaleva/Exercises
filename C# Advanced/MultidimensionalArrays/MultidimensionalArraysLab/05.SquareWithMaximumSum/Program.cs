using System;
using System.Linq;

namespace _05.SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowsAndCols = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int[,] matrix = new int[rowsAndCols[0], rowsAndCols[1]];

            for (int i = 0; i < rowsAndCols[0]; i++)
            {
                int[] arr = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int j = 0; j < rowsAndCols[0]; j++)
                {
                    matrix[i, j] = arr[j];
                }
            }


            int maxSum = int.MinValue;
            int bestRow = 0;
            int bestCol = 0;

            for (int rows = 0; rows < matrix.GetLength(0)-1; rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1)-1; cols++)
                {
                    var currentSum = matrix[rows, cols + 1] + matrix[rows + 1, cols] + matrix[rows, cols] + matrix[rows + 1, cols + 1];


                    if (currentSum>maxSum)
                    {
                        maxSum = currentSum;
                        bestRow = rows;
                        bestCol = cols;
                    }
                }
            }
            Console.WriteLine($"Sum = {maxSum}");
            Console.WriteLine($"{matrix[bestRow, bestCol]} {matrix[bestRow, bestCol + 1]} {matrix[bestRow, bestCol + 2]}");
            Console.WriteLine($"{matrix[bestRow + 1, bestCol]} {matrix[bestRow + 1, bestCol + 1]} {matrix[bestRow + 1, bestCol + 2]}");
            Console.WriteLine($"{matrix[bestRow + 2, bestCol]} {matrix[bestRow + 2, bestCol + 1]} {matrix[bestRow + 2, bestCol + 2]}");
        }
    }
}
