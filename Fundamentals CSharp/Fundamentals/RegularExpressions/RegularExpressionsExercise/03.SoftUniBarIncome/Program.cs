using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace _03.SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\%(?<customer>[A-Z][a-z]+)\%[^|$%.]*\<(?<product>\w+)\>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>\d+([.]\d+)?)\$";
            List<Order> orders = new List<Order>();

            string input = string.Empty; ;

            while ((input = Console.ReadLine()) != "end of shift")
            {
                Match match = Regex.Match(input, pattern);

                if (Regex.IsMatch(input, pattern) == false)
                {
                    continue;
                }

                string customerName = match.Groups["customer"].Value;
                string product = match.Groups["product"].Value;
                int quantity = int.Parse(match.Groups["count"].Value);
                decimal price = decimal.Parse(match.Groups["price"].Value);

                Order order = new Order(customerName, product, quantity, price);
                orders.Add(order);
            }

            foreach (var item in orders)
            {
                Console.WriteLine(item);
            }

            decimal totalPrice = orders.Sum(o => o.TotalPrice);

            string total = $"Total income: {totalPrice:F2}";

            Console.WriteLine(total);
        }
    }
    class Order
    {
        public Order(string customerName, string product, int quantity, decimal price)
        {
            CustomerName = customerName;
            Product = product;
            Quantity = quantity;
            Price = price;
        }

        public string CustomerName { get; set; }

        public string Product { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public decimal TotalPrice => this.Quantity * this.Price;

        public override string ToString()
        {
            string result = $"{CustomerName}: {Product} - {TotalPrice:F2}";
            return result;
        }
    }
}
    
