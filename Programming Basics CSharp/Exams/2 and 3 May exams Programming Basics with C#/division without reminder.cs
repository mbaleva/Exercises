using System;

namespace ConditionalllStatemants2
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            double count2 = 0;
            double count3 = 0;
            double count4 = 0;

            for (int i = 1; i <= n; i++)
            {
                double currentNumber = double.Parse(Console.ReadLine());
                if (currentNumber%2==0)
                {
                    count2++;
                }
                if (currentNumber%3==0)
                {
                    count3++;
                }
                if (currentNumber%4==0)
                {
                    count4++;
                }
            }
            double percentage2 = (count2 / n) * 100;
            double percentage3 = (count3 / n) * 100;
            double percentage4 = (count4 / n) * 100;

            Console.WriteLine($"{percentage2:F2}%");
            Console.WriteLine($"{percentage3:F2}%");
            Console.WriteLine($"{percentage4:F2}%");
        }
    }
}
