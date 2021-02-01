using System;
using System.Linq;
using System.Collections.Generic;

namespace _09.ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {

            int length = int.Parse(Console.ReadLine());
            List<int> list = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Distinct()
                .ToList();

            List<int> numbers = new List<int>();

            for (int i = 1; i <= length; i++)
            {
                if (Divide(i, list))
                {
                    numbers.Add(i);
                }
            }

            Console.WriteLine(string.Join(" ", numbers));

        }

        private static bool Divide(int n, List<int> list)
        {
            bool isHaveRemainder = true;

            foreach (var item in list)
            {
                if (n % item != 0)
                {
                    isHaveRemainder = false;
                }
            }
            return isHaveRemainder;
        }
    }
}
