using System;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal centuries = decimal.Parse(Console.ReadLine());
            decimal years = centuries * 100;
            decimal days = (int)(years * 365.2422M);
            decimal hours = days * 24;
            decimal minutes = hours * 60;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
