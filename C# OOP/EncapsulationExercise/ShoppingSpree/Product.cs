using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Product
    {
        public Product(string productName,double cost)
        {
            this.ProductName = productName;
            this.Cost = cost;
        }
        private string productName;
        private double cost;

        public string ProductName
        {
            get
            {
                return this.productName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                this.productName = value;
            }
        }

        public double Cost
        {
            get
            {
                return this.cost;
            }
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                this.cost = value;
            }
        }
    }
}
