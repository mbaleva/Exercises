using Microsoft.Win32.SafeHandles;
using System;

namespace ConditionalllStatemants2
{
    class Program
    {
        static void Main(string[] args)
        {
            double pricePerOneFlour = double.Parse(Console.ReadLine());
            double kilosFlour = double.Parse(Console.ReadLine());
            double kilosSugar = double.Parse(Console.ReadLine());
            double eggs = double.Parse(Console.ReadLine());
            double yeast = double.Parse(Console.ReadLine());

            double sugarPricePerOneKilos = pricePerOneFlour * 0.75;
            double eggsPerOnePrice = pricePerOneFlour * 1.1;
            double yeastPrice1 = sugarPricePerOneKilos * 0.2;

            double totalPrice = (kilosFlour * pricePerOneFlour) + (kilosSugar * sugarPricePerOneKilos) + (eggs * eggsPerOnePrice) + (yeast * yeastPrice1);
            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}
