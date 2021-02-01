using Microsoft.Win32.SafeHandles;
using System;

namespace ConditionalllStatemants2
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string device = Console.ReadLine();

            double ratting = 0.00;

            if (country == "Russia")
            {
                if (device == "ribbon")
                {
                    ratting = 9.1 + 9.4;
                }
                else if (device == "hoop")
                {
                    ratting = 9.3 + 9.8;
                }
                else if (device == "rope")
                {
                    ratting = 9.6 + 9;
                }
            }
            if (country == "Bulgaria")
            {
                if (device == "ribbon")
                {
                    ratting = 9.6 + 9.4;
                }
                else if (device == "hoop")
                {
                    ratting = 9.55 + 9.75;
                }
                else if (device == "rope")
                {
                    ratting = 9.5 + 9.4;
                }
            }
            if (country == "Italy")
            {
                if (device == "ribbon")
                {
                    ratting = 9.2 + 9.5;
                }
                else if (device == "hoop")
                {
                    ratting = 9.45 + 9.35;
                }
                else if (device == "rope")
                {
                    ratting = 9.7 + 9.15;
                }
            }
            Console.WriteLine($"The team of {country} get {ratting:F3} on {device}.");
            ratting = 20 - ratting;
            double percentage = (ratting / 20) * 100;
            Console.WriteLine($"{percentage:F2}%");
        }
    }
}
