using System;
using System.Text;

namespace _06._Middle_characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Console.WriteLine(middleCharacter(input));
        }
        static string middleCharacter(string input)
        {
            string middle = string.Empty;


            if (input.Length%2==1)
            {
                middle += input[input.Length / 2];
            }
            if (input.Length%2==0)
            {
                middle += input[(input.Length / 2) - 1];
                middle += input[input.Length / 2];
            }
            return middle;
        }
    }
}
