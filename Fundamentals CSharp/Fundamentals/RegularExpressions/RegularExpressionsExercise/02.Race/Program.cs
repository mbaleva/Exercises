using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace _02.Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(", ");

            Dictionary<string, int> name = new Dictionary<string, int>();

            foreach (var item in arr)
            {
                name.Add(item, 0);
            }

            string namePattern = @"[\W\d]";
            string numberPattern = @"[\WA-Za-z]";

            string input = Console.ReadLine();

            while (input!="end of race")
            {
                string names = Regex.Replace(input, namePattern, "");
                string distance = Regex.Replace(input, numberPattern, "");

                //Console.WriteLine(names);
                //Console.WriteLine(distance);


                int sum = 0; 

                foreach (var digit in distance)
                {
                    int currentDigit = int.Parse(digit.ToString());
                    sum += currentDigit;
                }

                if (name.ContainsKey(names))
                {
                    name[names] += sum;
                }
                input = Console.ReadLine();
            }

            int count = 1;

            foreach (var kvp in name.OrderByDescending(x=>x.Value))
            {
                string text = count == 1 ? "st" : count == 2 ? "nd" : "rd";

                Console.WriteLine($"{count++}{text} place: {kvp.Key}");

                if (count==4)
                {
                    break;
                }
            }
        }
    }
}
