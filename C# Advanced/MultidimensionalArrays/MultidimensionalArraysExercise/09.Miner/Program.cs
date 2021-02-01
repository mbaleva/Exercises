using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] pesho = Console.ReadLine().Split(' ').ToArray();

            int row = 0;
            int col = 0;

            string[][] jagged = new string[n][];

            for (int i = 0; i < n; i++)
            {

                jagged[i] = Console.ReadLine().Split(' ').ToArray();
                if (jagged[i].Contains("s"))
                {
                    row = i;
                    col = Array.IndexOf(jagged[i], "s");
                }
            }

            HashSet<Tuple<int, int>> myLocation = new HashSet<Tuple<int, int>>();

            LocationsForC(myLocation, jagged);
            Tuple<int, int> eLocation = LocationsForE(jagged);

            for (int i = 0; i < pesho.Length; i++)
            {
                string currentDirection = pesho[i];
                switch (currentDirection)
                {
                    case "left":
                        if (col > 0)
                        {
                            col--;
                        }
                        break;
                    case "right":
                        if (col + 1 < jagged[row].Length)
                        {
                            col++;
                        }
                        break;
                    case "up":
                        if (row > 0)
                        {
                            row--;
                        }
                        break;
                    case "down":
                        if (row + 1 < jagged.Length)
                        {
                            row++;
                        }
                        break;
                }
                if (eLocation.Equals(new Tuple<int, int>(row, col)))
                {
                    Console.WriteLine($"Game over! ({row}, {col})");
                    return;
                }
                if (myLocation.Contains(new Tuple<int, int>(row, col)))
                {
                    myLocation.Remove(new Tuple<int, int>(row, col));
                    if (myLocation.Count == 0)
                    {
                        Console.WriteLine($"You collected all coals! ({row}, {col})");
                        return;
                    }
                }

            }
            Console.WriteLine($"{myLocation.Count} coals left. ({row}, {col})");
        }
        private static Tuple<int, int> LocationsForE(string[][] jagged)
        {
            int row = 0;
            int col = 0;
            for (int i = 0; i < jagged.Length; i++)
            {
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    if (jagged[i][j] == "e")
                    {
                        row = i;
                        col = j;
                    }
                }
            }
            return new Tuple<int, int>(row, col);
        }
        private static HashSet<Tuple<int, int>> LocationsForC(HashSet<Tuple<int, int>> bum, string[][] jagged)
        {
            for (int i = 0; i < jagged.Length; i++)
            {
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    if (jagged[i][j] == "c")
                    {
                        bum.Add(new Tuple<int, int>(i, j));
                    }
                }
            }

            return bum;
        }
    }
}
