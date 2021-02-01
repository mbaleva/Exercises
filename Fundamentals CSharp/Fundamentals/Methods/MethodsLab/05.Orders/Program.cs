using System;

namespace _05.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string orders = Console.ReadLine();
            double countOrders = double.Parse(Console.ReadLine());
            result(orders, countOrders);
        }

        static void result(string command, double count)
        {
            double result = 0;
            if (command == "coffee")
            {
                result = count * 1.5;
                Console.WriteLine($"{result:F2}");
            }
            else if (command == "water")
            {
                result = count * 1;
                Console.WriteLine($"{result:F2}");
            }
            else if (command == "coke")
            {
                result = count * 1.4;
                Console.WriteLine($"{result:F2}");
            }
            else if (command == "snacks")
            {
                result = count * 2;
                Console.WriteLine($"{result:F2}");
            }
        }
    }
}
