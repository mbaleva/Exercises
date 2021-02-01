using System;
using System.Diagnostics.CodeAnalysis;

namespace ConditionalllStatemants2
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double max = double.MinValue;
            string text = string.Empty;
            while (true)
            {
                string word = Console.ReadLine();

                if (word == "Stop")
                {
                    break;
                }

                for (int i = 0; i < word.Length; i++)
                {
                    int currentNumber = int.Parse(Console.ReadLine());

                    if (currentNumber == word[i])
                    {
                        sum += 10;
                    }
                    else
                    {
                        sum += 2;
                    }
                    if (sum>=max)
                    {
                        max = sum;
                        text = word;

                    }

                }
                sum = 0;

            }
            Console.WriteLine($"The winner is {text} with {max} points!");
            
        }
    }
}
