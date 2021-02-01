using System;
using System.Linq;
using System.Collections.Generic;

namespace _03.WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonyms = Console.ReadLine();

                if (dictionary.ContainsKey(word) == false)
                {
                    dictionary.Add(word, new List<string>());
                }
                dictionary[word].Add(synonyms);
            }
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} - " +
                    $"{string.Join(", ", item.Value)}");
            }
        }
    }
}
