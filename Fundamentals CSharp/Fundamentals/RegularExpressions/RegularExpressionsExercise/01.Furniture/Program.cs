using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace _01.Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            //string regex = @">>(?<name>[A-Za-z]+)<<(?<price>\d+(.\d+)?)!(?<quant>\d+)";

            Regex r = new Regex(@">>(?<name>[A-Za-z]+)<<(?<price>\d+(.\d+)?)!(?<quant>\d+)");
            double totalPrice = 0.00;
            var output = new List<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Purchase")
                {
                    break;
                }

                Match matches = r.Match(input);

                if (matches.Success)
                {
                    var name = matches.Groups["name"].Value;
                    var price = double.Parse(matches.Groups["price"].Value);
                    var quantity = double.Parse(matches.Groups["quant"].Value);
                    output.Add(name);
                    totalPrice += price * quantity;
                }
            }
            Console.WriteLine("Bought furniture:");
            if (output.Count>0)
            {
                Console.WriteLine(string.Join(Environment.NewLine,output));
            }

            Console.WriteLine($"Total money spend: {totalPrice:F2}");
        }
    }
}
