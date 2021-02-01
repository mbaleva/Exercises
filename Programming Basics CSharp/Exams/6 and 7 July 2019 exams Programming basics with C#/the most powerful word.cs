using System;
using System.Diagnostics.CodeAnalysis;

namespace ConditionalllStatemants2
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double sumOfTheMostPowerfulWord = 0.00;
            double max = double.MinValue;
            string theMostPowerfulWord = string.Empty;
            while (true)
            {
                string word = Console.ReadLine();

                if (word == "End of words")
                {
                    break;
                }

                for (int i = 0; i < word.Length; i++)
                {
                    int letter = (int)(word[i]);
                    sum += letter;
                }

                if (word[0] == 'a' || word[0] == 'e' || word[0] == 'i' || word[0] == 'u' || word[0] == 'o' || word[0] == 'y' ||
                    word[0] == 'A' || word[0] == 'E' || word[0] == 'I' || word[0] == 'U' || word[0] == 'O' || word[0] == 'Y')

                {
                    sum *= word.Length;
                }
                else
                {
                    sum  = Math.Floor(sum/word.Length);
                }
                if (sum > max)
                {

                    max = sum;
                    theMostPowerfulWord = word;
                }
                sum = 0;
            }
            Console.WriteLine($"The most powerful word is {theMostPowerfulWord} - {max}");
        }
    }
}

