using Microsoft.Win32.SafeHandles;
using System;

namespace ConditionalllStatemants2
{
    class Program
    {
        static void Main(string[] args)
        {
            double countPeople = double.Parse(Console.ReadLine());
            double budjet = double.Parse(Console.ReadLine());

            double easterBread = Math.Ceiling(countPeople / 3);
            double eggs = countPeople * 2;

            double easterBreadPrice = easterBread * 4;
            double eggsPrice = eggs * 0.45;

            double totalPrice = easterBreadPrice + eggsPrice;
            double diff = budjet - totalPrice;
            if (totalPrice<=budjet)
            {
                Console.WriteLine($"Lyubo bought {easterBread} Easter bread and {eggs} eggs.");
                Console.WriteLine($"He has {diff:F2} lv. left.");
            }
            else
            {
                Console.WriteLine($"Lyubo doesn't have enough money.");
                Console.WriteLine($"He needs {Math.Abs(diff):F2} lv. more.");
            }
        }
    }
}
