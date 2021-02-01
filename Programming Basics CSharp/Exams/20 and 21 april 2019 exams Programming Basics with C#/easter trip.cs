using System;

namespace ConditionalllStatemants2
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            string data = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());


            double price = 0.00;

            if (destination=="France")
            {
                if (data == "21-23")
                {
                    price = nights * 30;
                }
                else if (data == "24-27")
                {
                    price = nights * 35;
                }
                else if (data == "28-31")
                {
                    price = nights * 40;
                }
            }
            if (destination == "Italy")
            {
                if (data == "21-23")
                {
                    price = nights * 28;
                }
                else if (data == "24-27")
                {
                    price = nights * 32;
                }
                else if (data == "28-31")
                {
                    price = nights * 39;
                }
            }
            if (destination == "Germany")
            {
                if (data == "21-23")
                {
                    price = nights * 32;
                }
                else if (data == "24-27")
                {
                    price = nights * 37;
                }
                else if (data == "28-31")
                {
                    price = nights * 43;
                }
            }
            Console.WriteLine($"Easter trip to {destination} : {price:F2} leva.");
        }
    }
}
