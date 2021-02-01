using System;
using System.Linq;

namespace _03._Zig_zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] firstArray = new int[n];
            int[] secondArray = new int[n];

            int counter = 0;

            for (int i = 0; i < n; i++)
            {
                int[] currentArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

                counter++;
                if (counter == 1)
                {
                    firstArray[i] = currentArray[0];
                    secondArray[i] = currentArray[1];
                }
                if (counter == 2)
                {
                    counter = 0;
                    firstArray[i] = currentArray[1];
                    secondArray[i] = currentArray[0];
                }
            }
            Console.WriteLine(string.Join(" ", firstArray));
            Console.WriteLine(string.Join(" ", secondArray));
        }
    }
}
