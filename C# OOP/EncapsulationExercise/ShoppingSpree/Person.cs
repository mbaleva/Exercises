using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ShoppingSpree
{
    public class Person
    {

        public Person(string name,double money)
        {
            this.Name = name;
            this.Money = money;
            this.products = new List<Product>();
        }
        private string name;
        private double money;
        private List<Product> products;


        public string Name 
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                this.name = value;
            }
        }
        public double Money
        {
            get
            {
                return this.money;
            }
            private set
            {
                if (value<0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                this.money = value;
            }
        }

        public IReadOnlyList<Product> Products
        {
            get
            {
                return this.products.AsReadOnly();
            }
        }

        public void AddProduct(Product product)
        {
            if (product.Cost > this.Money)
            {
                throw new InvalidOperationException($"{this.Name} can't afford {product.ProductName}");
            }

            this.products.Add(product);
            this.Money -= product.Cost;
        }

        public override string ToString()
        {
            if (this.Products.Count == 0)
            {
                return $"{this.Name} - Nothing bought";
            }

            var products = this.products.Select(x => x.ProductName);

            return $"{this.Name} - {string.Join(", ", products)}";
        }
    }
}
