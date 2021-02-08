using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            List<Product> products = new List<Product>();

            string[] peopleInput = 
                Console.ReadLine()
                .Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            string[] productsInput = 
                Console.ReadLine()
                .Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            try
            {
                foreach (var token in peopleInput)
                {
                    var tokens = token.Split(new[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
                    var name = tokens[0];
                    var money = double.Parse(tokens[1]);

                    var person = new Person(name, money);
                    persons.Add(person);
                }

                foreach (var token in productsInput)
                {
                    var info = token.Split(new[] { '=' }, StringSplitOptions.RemoveEmptyEntries);
                    var name = info[0];
                    var cost = double.Parse(info[1]);

                    var product = new Product(name, cost);
                    products.Add(product);
                }

                string command;
                while ((command = Console.ReadLine()) != "END")
                {
                    var info = command.Split();
                    var personName = info[0];
                    var productName = info[1];
                    var product = products.FirstOrDefault(x => x.ProductName == productName);

                    try
                    {
                        persons.FirstOrDefault(p => p.Name == personName)
                              .AddProduct(product);
                        Console.WriteLine($"{personName} bought {productName}");
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine(e.Message);
                    }
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            foreach (var item in persons)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
