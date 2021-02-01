using System;
using System.Linq;

namespace _01.DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = arr[j];
                }
            }

            int sumForFirstDiagonal = 0;

            for (int i = 0; i < n; i++)
            {
                sumForFirstDiagonal += matrix[i, i];
            }

            int sumForSecondDiagonal = 0;

            for (int i = 0; i < n; i++)
            {
                int index = matrix.GetLength(1) - i-1;

                sumForSecondDiagonal += matrix[i, index];
            }
            int result = Math.Abs(sumForFirstDiagonal - sumForSecondDiagonal);
            Console.WriteLine(result);
        }
    }
}
