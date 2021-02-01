using System;
using System.Linq;

namespace _02._2X2SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rows = arr[0];
            int cols = arr[1];

            string[,] matrix = new string[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string[] bumm = Console.ReadLine().Split().ToArray();

                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = bumm[j];
                }
            }
            int counter = 0;

            for (int i = 0; i < matrix.GetLength(0)-1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1)-1; j++)
                {
                    if (matrix[i,j]==matrix[i,j+1]
                        &&matrix[i+1,j]==matrix[i+1,j+1]
                        &&matrix[i,j]==matrix[i+1,j]
                        &&matrix[i,j+1]==matrix[i+1,j+1])
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
