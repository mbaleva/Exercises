using System;

namespace ConditionalllStatemants2
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            double statuetki = n * 0.7;
            double food = statuetki * 0.85;
            double sound = food / 2;
            double totalPrice = statuetki + food + sound+n;
            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}
