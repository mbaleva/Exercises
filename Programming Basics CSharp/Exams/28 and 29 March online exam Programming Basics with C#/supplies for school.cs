using System;


namespace NestedLoopsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int pensCount = int.Parse(Console.ReadLine());
            int markerCount = int.Parse(Console.ReadLine());
            double cleaning = double.Parse(Console.ReadLine());
            double percentage =double.Parse(Console.ReadLine());


            double pensPrice = pensCount * 5.80;
            double markerPrice = markerCount * 7.20;
            double cleaningPrice = cleaning * 1.20;
            double priceWithoutDiscount = (pensPrice + markerPrice + cleaningPrice)*percentage/100;
            double totalPrice = (pensPrice + markerPrice + cleaningPrice) - priceWithoutDiscount;
            Console.WriteLine($"{totalPrice:F3}");
            

        }
    }
}
