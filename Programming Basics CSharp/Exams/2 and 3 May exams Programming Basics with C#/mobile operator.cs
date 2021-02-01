using System;

namespace ConditionalllStatemants2
{
    class Program
    {
        static void Main(string[] args)
        {
            string time = Console.ReadLine();
            string typePackage = Console.ReadLine();
            string internet = Console.ReadLine();
            double months = double.Parse(Console.ReadLine());

            double price = 0.00;
            double totalPrice = 0.00;

            if (time == "one")
            {

                if (typePackage == "Small" && internet == "yes")
                {
                    price = (9.98 + 5.50) * months;
                }
                else if (typePackage == "Small" && internet == "no")
                {
                    price = 9.98 * months;

                }
                if (typePackage == "Middle" && internet == "yes")
                {
                    price = (18.99 + 4.35) * months;
                }
                else if (typePackage == "Middle" && internet == "no")
                {
                    price = 18.99 * months;

                }
                if (typePackage == "Large" && internet == "yes")
                {
                    price = (25.98 + 4.35) * months;
                }
                else if (typePackage == "Large" && internet == "no")
                {
                    price = 25.98 * months;

                }
                if (typePackage == "ExtraLarge" && internet == "yes")
                {
                    price = (35.99 + 3.85) * months;
                }
                else if (typePackage == "ExtraLarge" && internet == "no")
                {
                    price = 35.99 * months;

                }

                Console.WriteLine($"{price:F2} lv.");

            }
            else
            {
                if (typePackage == "Small" && internet == "yes")
                {
                    price = (8.58 + 5.50) * months;
                }
                else if (typePackage == "Small" && internet == "no")
                {
                    price = 8.58 * months;

                }
                if (typePackage == "Middle" && internet == "yes")
                {
                    price = (17.09 + 4.35) * months;
                }
                else if (typePackage == "Middle" && internet == "no")
                {
                    price = 17.09 * months;

                }
                if (typePackage == "Large" && internet == "yes")
                {
                    price = (23.59 + 4.35) * months;
                }
                else if (typePackage == "Large" && internet == "no")
                {
                    price = 23.59 * months;

                }
                if (typePackage == "ExtraLarge" && internet == "yes")
                {
                    price = (31.79 + 3.85) * months;
                }
                else if (typePackage == "ExtraLarge" && internet == "no")
                {
                    price = 31.79 * months;

                }
                totalPrice = price - (price * 0.0375);
                Console.WriteLine($"{totalPrice:F2} lv.");
            }
        }
    }
}
