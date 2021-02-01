using System;
using System.Linq;
using System.Collections.Generic;

namespace _05.ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] people = Console.ReadLine().Split(';');
            string[] products = Console.ReadLine().Split(';');

            List<Person> personLists = new List<Person>();

            for (int i = 0; i < people.Length; i++)
            {
                string[] pesho = people[i].Split('=');

                string name = pesho[0];
                int budjet = int.Parse(pesho[1]);

                Person person = new Person(name, budjet);

                personLists.Add(person);
            }
            List<Product> productsList = new List<Product>();

            for (int i = 0; i < products.Length; i++)
            {
                string[] pesho = products[i].Split('=');

                string name = pesho[0];
                int price = int.Parse(pesho[1]);

                Product product = new Product(name, price);

                productsList.Add(product);
            }


            string command = string.Empty;


            while ((command = Console.ReadLine()) != "END")
            {
                string[] pesho = command.Split();

                string currentPerson = pesho[0];
                string product = pesho[1];

                if (personLists.Find(x => x.Name == currentPerson).Money >= productsList.Find(x => x.NamePerProduct == product).Cost)
                {
                    personLists.Find(x => x.Name == currentPerson).Money -= productsList.Find(x => x.NamePerProduct == product).Cost;

                    personLists.Find(x => x.Name == currentPerson).Bag.Add(product);

                    Console.WriteLine($"{currentPerson} bought {product}");
                }
                else
                {
                    Console.WriteLine($"{currentPerson} can't afford {product}");
                }
            }
            foreach (var item in personLists)
            {
                if (item.Bag.Count > 0)
                {
                    Console.WriteLine($"{item.Name} - {string.Join(", ", item.Bag)}");
                }
                else
                {
                    Console.WriteLine($"{item.Name} - Nothing bought");
                }
            }
        }

    }
    class Person
    {
        public Person(string name, double money)
        {
            Name = name;
            Money = money;
            Bag = new List<string>();
        }

        public string Name { get; set; }
        public double Money { get; set; }
        public List<string> Bag { get; set; }
    }
    class Product
    {
        public Product(string namePerProduct, double cost)
        {
            NamePerProduct = namePerProduct;
            Cost = cost;
        }

        public string NamePerProduct { get; set; }
        public double Cost { get; set; }
    }
}
