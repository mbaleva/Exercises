using System;

namespace _03.Characters_in_range
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());

            characterInRange(start, end);
        }
        static void characterInRange(char start, char end)
        {
            int max = Math.Max(start, end);
            int min = Math.Min(start, end);
            for (int i = ++min; i < max; i++)
            {
                Console.Write((char)i + " ");
            }
            Console.WriteLine();
        }
    }
}
