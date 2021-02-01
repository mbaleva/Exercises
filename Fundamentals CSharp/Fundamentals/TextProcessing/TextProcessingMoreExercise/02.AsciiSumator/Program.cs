using System;
using System.Text;
using System.Linq;

namespace _02.AsciiSumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            string randomString = Console.ReadLine();

            int startIndex = (int)Math.Min(firstChar, secondChar);
            int endIndex = (int)Math.Max(firstChar, secondChar);

            int sum = 0;

            for (int i = 0; i < randomString.Length; i++)
            {
                int currentChar = (int)randomString[i];

                if (currentChar>startIndex&&currentChar<endIndex)
                {
                    sum += currentChar;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
