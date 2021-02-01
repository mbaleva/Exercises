using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace _02.MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringsRegex = @"\+359([ -])2\1\d{3}\1\d{4}\b";
            string input = Console.ReadLine();
            Regex regex = new Regex(stringsRegex);

            MatchCollection matches = regex.Matches(input);

            string[] matchPhones = matches.Cast<Match>().Select(x => x.Value.Trim()).ToArray();
            Console.WriteLine(string.Join(", ", matchPhones));


        }
    }
}
