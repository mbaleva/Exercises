using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace _08.LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            string[] arr = Console.ReadLine()
                           .Split(' ', 
                           StringSplitOptions.RemoveEmptyEntries);

            //A12b s17G
            double sum = 0.00;
            for (int i = 0; i < arr.Length; i++)
            {
                //A12b

                string currentText = arr[i];

                char firstLetter = currentText[0];
                char secondLetter = currentText[currentText.Length-1];
                double digit = 
                double.Parse(currentText.Substring
                (1,currentText.Length-2));

                int firstLetterIndex = alphabet.IndexOf(char.ToUpper(firstLetter));
                int secondLetterIndex = alphabet.IndexOf(char.ToUpper(secondLetter));

                if ((int) firstLetter>=65&&(int)firstLetter<=90)
                {
                    digit = digit /( firstLetterIndex + 1);
                }
                else
                {
                    digit = digit * (firstLetterIndex + 1);
                }

                if ((int)secondLetter >= 65 && (int)secondLetter <= 90)
                {
                    digit = digit - (secondLetterIndex + 1);
                }
                else
                {
                    digit = digit + (secondLetterIndex + 1);
                }
                sum += digit;
            }
            Console.WriteLine($"{sum:F2}");
        }
    }
}
