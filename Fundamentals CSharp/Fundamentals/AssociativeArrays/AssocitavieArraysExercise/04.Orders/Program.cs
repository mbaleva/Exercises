using System;
using System.Linq;
using System.Collections.Generic;

namespace _04.Orders
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, double> dictionary = new Dictionary<string, double>();
            Dictionary<string, int> quantity = new Dictionary<string, int>();
       
            
            while (true)
            {
                string command = Console.ReadLine();

                if (command=="buy")
                {
                    break;
                }

                string[] arr = command
                              .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                              .ToArray();
                //Beer 2.40 350
                //Water 1.25 200
                //IceTea 5.20 100
                //Beer 1.20 200
                //IceTea 0.50 120
                //buy
                if (!dictionary.ContainsKey(arr[0]))
                {
                    dictionary.Add(arr[0], double.Parse(arr[1]));
                    quantity.Add(arr[0], int.Parse(arr[2]));
                }
                else
                {
                    dictionary[arr[0]] = double.Parse(arr[1]);
                    quantity[arr[0]] += int.Parse(arr[2]);
                }
                
            }
            foreach (var item in quantity)
            {
                double price = dictionary[item.Key];
                double result = price*item.Value;
                Console.WriteLine($"{item.Key} -> {result:F2}");
            }
        }
    }
}
