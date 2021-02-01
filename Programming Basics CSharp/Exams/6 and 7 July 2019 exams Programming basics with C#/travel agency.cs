using System;

namespace ConditionalllStatemants2
{
    class Program
    {
        static void Main(string[] args)
        {
            string townName = Console.ReadLine();
            string typePackage = Console.ReadLine();
            string VIPdiscount = Console.ReadLine();
            int countDays = int.Parse(Console.ReadLine());

            double price = 0.00;

            bool isInvalid = true;

            if ((townName == "Bansko" || townName == "Borovets") && (typePackage == "noEquipment" || typePackage == "withEquipment"))
            {
                if (typePackage == "noEquipment")
                {
                    if (VIPdiscount == "yes")
                    {
                        price = 80 * 0.95;
                    }
                    else
                    {
                        price = 80;
                    }
                }
                else if (typePackage == "withEquipment")
                {
                    if (VIPdiscount == "yes")
                    {
                        price = 100 * 0.9;
                    }
                    else
                    {
                        price = 100;
                    }
                }
            }
            else if ((townName == "Varna" || townName == "Burgas") && (typePackage == "noBreakfast" || typePackage == "withBreakfast"))
            {
                if (typePackage == "noBreakfast")
                {
                    if (VIPdiscount == "yes")
                    {
                        price = 100 * 0.93;
                    }
                    else
                    {
                        price = 100;
                    }
                }
                else if (typePackage == "withBreakfast")
                {
                    if (VIPdiscount == "yes")
                    {
                        price = 130 * 0.88;
                    }
                    else
                    {
                        price = 130;
                    }
                }
            }
            else
            {
                Console.WriteLine($"Invalid input!");
                isInvalid = false;
            }
            double totalPrice = 0.00;

            if (countDays < 1)
            {
                Console.WriteLine($"Days must be positive number!");
            }
            if (isInvalid)
            {


                if (countDays >= 1 && countDays <= 7)
                {
                    totalPrice = price * countDays;
                    Console.WriteLine($"The price is {totalPrice:F2}lv! Have a nice time!");
                }
                else if (countDays > 7)
                {
                    totalPrice = price * (countDays - 1);
                    Console.WriteLine($"The price is {totalPrice:F2}lv! Have a nice time!");

                }
            }
        }
    }
}