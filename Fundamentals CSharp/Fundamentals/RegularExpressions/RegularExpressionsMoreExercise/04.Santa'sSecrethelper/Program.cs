using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _04.Santa_sSecrethelper
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\@([A-Za-z]+)[^\@\-!:>]*!(G)!";

            Regex regex = new Regex(pattern);

            int key = int.Parse(Console.ReadLine());

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                StringBuilder decrypted = new StringBuilder();

                for (int i = 0; i < input.Length; i++)
                {
                    char symbol = (char)(input[i] - key);
                    decrypted.Append(symbol);
                }

                Match match = Regex.Match(decrypted.ToString(), pattern);

                if (match.Success)
                {
                    string name = match.Groups[1].ToString();
                    Console.WriteLine(name);
                }
            }
        }
    }
}
