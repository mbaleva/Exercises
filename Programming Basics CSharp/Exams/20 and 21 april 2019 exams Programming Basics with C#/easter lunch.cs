using System;

namespace ConditionalllStatemants2
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int countEggs = int.Parse(Console.ReadLine());
            int countC = int.Parse(Console.ReadLine());

            double totalPrice = (count * 3.2) + (countEggs * 4.35) + (countEggs * 12 * 0.15) + (countC * 5.4);

            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}
