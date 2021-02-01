using System;
using System.Text.RegularExpressions;

namespace _03.MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex pesho = new Regex(@"\b(?<day>\d{2})([-.\/])(?<month>[A-Z]{1}[a-z]{2})\1(?<year>\d{4})");

            MatchCollection matches = pesho.Matches(input);

            foreach (Match item in matches)
            {
                var day = item.Groups["day"].Value;
                var month = item.Groups["month"].Value;
                var year = item.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
