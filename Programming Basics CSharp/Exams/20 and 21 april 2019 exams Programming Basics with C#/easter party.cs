using System;

namespace ConditionalllStatemants2
{
    class Program
    {
        static void Main(string[] args)
        {
            int countPeople = int.Parse(Console.ReadLine());
            double foodPerOnePerson = double.Parse(Console.ReadLine());
            double budjet = double.Parse(Console.ReadLine());

            double cakePrice = budjet * 0.1;

            if (countPeople>=10&&countPeople<=15)
            {
                foodPerOnePerson *= 0.85;
            }
            else if (countPeople>15&&countPeople<=20)
            {
                foodPerOnePerson *= 0.8;
            }
            else if (countPeople>20)
            {
                foodPerOnePerson *= 0.75;
            }
            double price = foodPerOnePerson * countPeople + cakePrice;
            double diff = budjet - price;
            if (price<=budjet)
            {
                Console.WriteLine($"It is party time! {diff:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"No party! {Math.Abs(diff):F2} leva needed.");
            }
        }
    }
}
