using System;
using System.Linq;

namespace _06.Jagged_ArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] jagged = new int[n][];

            for (int i = 0; i < jagged.GetLength(0); i++)
            {
                int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jagged[i] = new int[n];
                jagged[i] = arr.ToArray();
            }

            string command = string.Empty;

            while ((command=Console.ReadLine())!="END")
            {
                var splitted = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (splitted[0]=="Add")
                {
                    int rowIndex = int.Parse(splitted[1]);
                    int colIndex = int.Parse(splitted[2]);

                    if (rowIndex>=0&&colIndex>=0&&rowIndex<jagged.GetLength(0)&&colIndex<jagged.GetLength(0))
                    {
                        jagged[rowIndex][colIndex] += int.Parse(splitted[3]);
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }

                if (splitted[0] == "Subtract")
                {
                    int rowIndex = int.Parse(splitted[1]);
                    int colIndex = int.Parse(splitted[2]);

                    if (rowIndex >= 0 && colIndex >= 0 && rowIndex < jagged.GetLength(0) && colIndex < jagged.GetLength(0))
                    {
                        jagged[rowIndex][colIndex] -= int.Parse(splitted[3]);
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }
            }
            foreach (var item in jagged)
            {
                Console.WriteLine(string.Join(" ", item));
            }
        }
    }
}
