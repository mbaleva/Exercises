using System;
using System.Linq;
using System.Collections.Generic;

namespace _02.Odd_occurence
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                            .Split(' ', StringSplitOptions.RemoveEmptyEntries);


            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (string word in words)
            {
                string wordToLowerCase = word.ToLower();

                if (counts.ContainsKey(wordToLowerCase))
                {
                    counts[wordToLowerCase]++;
                }
                else
                {
                    counts.Add(wordToLowerCase, 1);
                }
            }

            foreach (var count in counts)
            {
                if (count.Value%2!=0)
                {
                    Console.Write(count.Key + " ");
                }
            }
        }
    }
}
