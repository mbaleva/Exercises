using System;
using System.Linq;

namespace _08.Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];


            ReadMatrixFromConsole(matrix);

            string[] coordinates = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Explode(matrix, coordinates);

            int countCells = 0;
            int sum = 0;

            foreach (var item in matrix)
            {
                if (item > 0)
                {
                    countCells++;
                    sum += item;
                }
            }

            Console.WriteLine($"Alive cells: {countCells}");
            Console.WriteLine($"Sum: {sum}");
            PrintMatrix(matrix);
        }
        private static void ReadMatrixFromConsole(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] currentRow = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }
        }
        private static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");

                }
                Console.WriteLine();
            }
        }
        private static void Explode(int[,] matrix, string[] coordinates)
        {
            foreach (var item in coordinates)
            {
                int[] currentBomb = item
                    .Split(",", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int currentRow = currentBomb[0];
                int currentCol = currentBomb[1];

                int bomb = matrix[currentRow, currentCol];


                for (int row = currentRow - 1; row <= currentRow + 1; row++)
                {
                    for (int col = currentCol - 1; col <= currentCol + 1; col++)
                    {
                        if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1))
                        {
                            if (matrix[row, col] <= 0 || bomb < 0)
                            {
                                continue;
                            }
                            matrix[row, col] -= bomb;
                        }

                    }

                }

            }
        }
    }
}
