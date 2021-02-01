using System;
using System.Numerics;
using System.Text;

namespace DataTypesAndVariablesMoreExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            string output = string.Empty;


            for (int i = 1; i <=n; i++)
            {
                char letter = char.Parse(Console.ReadLine());

                int currentLetter = (int)letter;
                currentLetter += key;

                char outputLetter = (char)currentLetter;

                output += outputLetter;

            }
            Console.WriteLine($"{output}");
        }
    }
}

