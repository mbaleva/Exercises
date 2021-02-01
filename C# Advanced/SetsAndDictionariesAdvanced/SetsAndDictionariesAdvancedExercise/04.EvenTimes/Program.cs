using System;
using System.Linq;
using System.Collections.Generic;

namespace _04.EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<int, int> dict = new Dictionary<int, int>();

            if (n<0)
            {
                return;
            }
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (!dict.ContainsKey(number))
                {
                    dict.Add(number, 0);
                }
                dict[number]++;
            }

            foreach (var item in dict)
            {
                if (item.Value%2==0)
                {
                    Console.WriteLine(item.Key);
                    break;
                }
            }
        }
    }
}
