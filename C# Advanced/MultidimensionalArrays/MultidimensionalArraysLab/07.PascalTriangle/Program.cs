using System;

namespace _07.PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            long[][] pascal = new long[n][];

            int current = 1;

            for (long i = 0; i < n; i++)
            {
                pascal[i] = new long[current];
                long[] currentRow = pascal[i];
                currentRow[0] = 1;
                currentRow[currentRow.Length - 1] = 1;
                current++;

                if (currentRow.Length>2)
                {
                    for (int j = 1; j < currentRow.Length-1; j++)
                    {
                        long[] previousRow = pascal[i - 1];
                        long previousRowSum = previousRow[j] + previousRow[j - 1];
                        currentRow[j] = previousRowSum;
                    }
                }
            }
            foreach (var item in pascal)
            {
                Console.WriteLine(string.Join(" ", item));
            }
        }
    }
}
