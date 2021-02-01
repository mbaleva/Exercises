using System;
using System.Text.RegularExpressions;

namespace _01.MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringRegex = @"\b[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+\b";

            string input = Console.ReadLine();

            var regex = new Regex(@"\b[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+\b");

            MatchCollection mathe = regex.Matches(input);

            foreach (Match item in mathe)
            {
                Console.Write(item.Value + " ");
            }
        }
       
    }
}