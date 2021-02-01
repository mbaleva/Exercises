using System;
using System.Linq;
using System.Collections.Generic;

namespace _04.CitiesByContinentAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> dict = new Dictionary<string, Dictionary<string, List<string>>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] arr = Console.ReadLine().Split().ToArray();

                string continentName = arr[0];
                string countryName = arr[1];
                string townName = arr[2];

                if (!dict.ContainsKey(continentName))
                {
                    dict.Add(continentName, new Dictionary<string, List<string>>());
                }
                if (!dict[continentName].ContainsKey(countryName))
                {
                    dict[continentName].Add(countryName, new List<string>());
                    //dict[continentName][countryName].Add(townName);
                }
                if (dict.ContainsKey(continentName))
                {
                    if (dict[continentName].ContainsKey(countryName))
                    {
                        dict[continentName][countryName].Add(townName);
                    }
                }
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key}:");

                foreach (var pesho in item.Value)
                {
                    Console.WriteLine($"{pesho.Key} -> {string.Join(", ", pesho.Value)}");
                }
            }
        }
    }
}
