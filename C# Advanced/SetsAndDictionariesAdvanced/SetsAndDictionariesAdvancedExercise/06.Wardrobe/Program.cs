using System;
using System.Collections.Generic;

namespace _06.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> dict = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] arr = Console.ReadLine().Split(" -> ");

                if (!dict.ContainsKey(arr[0]))
                {
                    dict.Add(arr[0], new Dictionary<string, int>());
                }

                var splitted = arr[1].Split(',');

                for (int j = 0; j < splitted.Length; j++)
                {
                    if (!dict[arr[0]].ContainsKey(splitted[j]))
                    {
                        dict[arr[0]].Add(splitted[j], 0);
                    }
                    dict[arr[0]][splitted[j]]++;
                }
            }
            string[] lastCommand = Console.ReadLine().Split();

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} clothes:");

                foreach (var pesho in item.Value)
                {
                    Console.Write($"* {pesho.Key} - {pesho.Value}");

                    if (pesho.Key==lastCommand[1]&&item.Key==lastCommand[0])
                    {
                        Console.Write(" (found!)");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
