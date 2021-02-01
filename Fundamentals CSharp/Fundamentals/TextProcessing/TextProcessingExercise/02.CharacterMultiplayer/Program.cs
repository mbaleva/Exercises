using System;
using System.Linq;
using System.Text;

namespace _02.CharacterMultiplayer
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split().ToArray();

            string firstWord = arr[0];
            string secondWord = arr[1];

            string longestWord = firstWord;
            string shortestWord = secondWord;

            if (firstWord.Length<secondWord.Length)
            {
                longestWord = secondWord;
                shortestWord = firstWord;
            }

            Console.WriteLine(CharacterMultiply(longestWord, shortestWord));
        }
        public static int CharacterMultiply(string longestWord, string shortesWord)
        {
            int sum = 0;

            for (int i = 0; i < shortesWord.Length; i++)
            {
                var pesho = longestWord[i] * shortesWord[i];
                sum += pesho;
            }
            for (int i = shortesWord.Length; i < longestWord.Length; i++)
            {
                sum += longestWord[i];
            }
            return sum;
        }
    }
}
