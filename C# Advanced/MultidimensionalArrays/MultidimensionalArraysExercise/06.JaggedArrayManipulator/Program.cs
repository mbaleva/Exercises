using System;
using System.Linq;

namespace _06.JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int countRows = int.Parse(Console.ReadLine());

            if (countRows == 0)
            {
                return;
            }
            double[][] jagged = new double[countRows][];



            for (int i = 0; i < countRows; i++)
            {
                double[] pesho = Console.ReadLine()
                             .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                             .Select(double.Parse)
                             .ToArray();
                jagged[i] = pesho;
            }

            for (int i = 0; i < countRows - 1; i++)
            {
                double[] firstRow = jagged[i];
                double[] secondRow = jagged[i + 1];
                if (jagged[i].Length == jagged[i + 1].Length)
                {
                    jagged[i] = firstRow.Select(x => x * 2).ToArray();
                    jagged[i+1] = secondRow.Select(x => x * 2).ToArray();
                }
                else
                {
                    jagged[i] = firstRow.Select(x => x / 2).ToArray();
                    jagged[i+1]= secondRow.Select(x => x / 2).ToArray();
                }
            }

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmd = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (cmd[0] == "Add")
                {
                    int row = int.Parse(cmd[1]);
                    int col = int.Parse(cmd[2]);
                    double value = double.Parse(cmd[3]);

                    if (row < 0 || row >= countRows || col < 0 || col >= jagged[row].Length)
                    {
                        continue;
                    }
                    jagged[row][col] += value;
                }
                else if (cmd[0] == "Subtract")
                {
                    int row = int.Parse(cmd[1]);
                    int col = int.Parse(cmd[2]);
                    double value = double.Parse(cmd[3]);


                    if (row < 0 || row >= countRows || col < 0 || col >= jagged[row].Length)
                    {
                        continue;
                    }
                    jagged[row][col] -= value;
                }
            }
            for (int row = 0; row < countRows; row++)
            {
                for (int col = 0; col < jagged[row].Length; col++)
                {
                    Console.Write(jagged[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}