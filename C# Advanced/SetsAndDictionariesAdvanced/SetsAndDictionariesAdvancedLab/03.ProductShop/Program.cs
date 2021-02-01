using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> dict = new Dictionary<string, Dictionary<string, double>>();

            string command = string.Empty;

            while ((command=Console.ReadLine())!="Revision")
            {
                var splitted = command.Split(", ").ToArray();

                string shopName = splitted[0];
                string productName = splitted[1];
                double productPrice = double.Parse(splitted[2]);

                if (!dict.ContainsKey(shopName))
                {
                    dict.Add(shopName, new Dictionary<string, double>());
                }
                dict[shopName].Add(productName, productPrice);
            }
            foreach (var item in dict.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key}->");

                foreach (var pesho in item.Value)
                {
                    Console.WriteLine($"Product: {pesho.Key}, Price: {pesho.Value}");
                }
            }
        }
    }
}
