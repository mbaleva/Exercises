using System;
using System.Linq;

namespace _04.MatrixShufling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
               .Split(' ', StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();

            int rows = arr[0];
            int cols = arr[1];


            string[,] matrix = new string[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string[] pesho = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = pesho[j];
                }
            }

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "END")
            {
                string[] splitted = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (splitted[0] == "swap" && splitted.Length == 5)
                {
                    int firstRowIndex = int.Parse(splitted[1]);
                    int firstColIndex = int.Parse(splitted[2]);
                    int secondRowIndex = int.Parse(splitted[3]);
                    int secondColIndex = int.Parse(splitted[4]);


                    if (firstRowIndex >= 0 && firstRowIndex <= rows - 1 && firstColIndex >= 0 && firstColIndex <= cols - 1 &&
                        secondRowIndex >= 0 && secondRowIndex <= rows - 1 && secondColIndex >= 0 && secondColIndex <= cols - 1)
                    {
                        var temp = matrix[firstRowIndex, firstColIndex];
                        matrix[firstRowIndex, firstColIndex] = matrix[secondRowIndex, secondColIndex];
                        matrix[secondRowIndex, secondColIndex] = temp;

                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                Console.Write($"{matrix[i, j]} ");
                            }
                            Console.WriteLine();

                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }

                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }
    }
}