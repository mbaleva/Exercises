using System;

namespace ConditionalllStatemants2
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hoursPerOneDay = int.Parse(Console.ReadLine());

            double sum = 0.00;
            double totalSum = 0.00;

            int counter = 0;

            for (int i = 1; i <= days; i++)
            {
                counter++;
                for (int j = 1; j <= hoursPerOneDay; j++)
                {
                    if (i % 2 == 0 && j % 2 != 0)
                    {
                        sum += 2.5;
                    }
                    else if (i%2!=0&&j%2==0)
                    {
                        sum += 1.25;
                    }
                    else
                    {
                        sum += 1;
                    }
                }
                Console.WriteLine($"Day: {counter} - {sum:F2} leva");
                totalSum += sum;
                sum = 0;
            }
            Console.WriteLine($"Total: {totalSum:F2} leva");
        }
    }
}
