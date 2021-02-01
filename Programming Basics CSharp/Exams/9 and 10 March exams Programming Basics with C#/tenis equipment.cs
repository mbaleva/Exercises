using System;

namespace ConditionalllStatemants2
{
    class Program
    {
        static void Main(string[] args)
        {
            double tenisPrice = double.Parse(Console.ReadLine());
            int countTenis = int.Parse(Console.ReadLine());
            int countTrains = int.Parse(Console.ReadLine());

            double tenisTotalPrice = tenisPrice * countTenis;
            double trainsTotalPrice = (tenisPrice / 6) * countTrains;
            double othersPrice  = (tenisTotalPrice + trainsTotalPrice) * 0.2;
            double price = tenisTotalPrice + trainsTotalPrice + othersPrice;
            double djokovichPrice = price / 8;
            double others = price * 0.875;

            Console.WriteLine($"Price to be paid by Djokovic {Math.Floor(djokovichPrice)}");
            Console.WriteLine($"Price to be paid by sponsors {Math.Ceiling(others)}");
        }
    }
}
