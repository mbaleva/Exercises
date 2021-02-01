using Microsoft.Win32.SafeHandles;
using System;

namespace ConditionalllStatemants2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            double sum = 0.00;
            double totalSum = 0.00;
            for (int i = 1; i <= n; i++)
            {
                while (true)
                {
                    string command = Console.ReadLine();

                    if (command=="Finish")
                    {
                        break;
                    }
                    counter++;
                    if (command == "basket")
                    {
                        sum += 1.5;
                    }
                    else if (command == "wreath")
                    {
                        sum += 3.8;
                    }
                    else if (command == "chocolate bunny")
                    {
                        sum += 7;
                    }
                }
                if (counter%2==0)
                {
                    sum *= 0.8;
                }
                totalSum += sum;
                Console.WriteLine($"You purchased {counter} items for {sum:F2} leva.");
                sum = 0;
                counter = 0;
            }
            double average = totalSum / n;
            Console.WriteLine($"Average bill per client is: {average:F2} leva.");
        }
    }
}
