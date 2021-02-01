using System;
using System.Text;

namespace _01.ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string reversedWord = string.Empty;
           
            while (true)
            {
                string word = Console.ReadLine();
                
                if (word=="end")
                {
                    break;
                }

                for (int i = word.Length-1; i >= 0; i--)
                {
                    reversedWord+=word[i];
                }
                Console.WriteLine($"{word} = {reversedWord}");
                reversedWord = string.Empty;
            }
        }
    }
}
