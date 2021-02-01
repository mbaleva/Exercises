using System;
using System.Linq;
using System.Collections.Generic;

namespace _04.GenericSwapMethodInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<int> myList = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                myList.Add(input);
            }
            mmmmmmmmmmmmm<int> kkk = new mmmmmmmmmmmmm<int>(myList);

            int[] indexes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int firstIndex = indexes[0];
            int secondIndex = indexes[1];

            kkk.SwapElements(firstIndex, secondIndex);
            Console.WriteLine(kkk);
        }
    }
}
