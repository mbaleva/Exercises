using System;

namespace _02.GenericBoxOfInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                Box box = new Box(currentNum);
                Console.WriteLine(box);
            }
        }
    }
}
