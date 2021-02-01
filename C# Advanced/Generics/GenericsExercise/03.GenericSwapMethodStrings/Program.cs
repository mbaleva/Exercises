using System;
using System.Linq;
using System.Collections.Generic;


namespace _03.GenericSwapMethodStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> myList = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                myList.Add(input);

            }
            IDK<string> kkk = new IDK<string>(myList);

            int[] indexes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int firstIndex = indexes[0];
            int secondIndex = indexes[1];

            kkk.SwapElements(firstIndex,secondIndex);
            Console.WriteLine(kkk);
        }
    }
}
