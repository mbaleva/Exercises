﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    interface IProduceSound
    {
        string ProduceSound();
    }

    abstract class Animal
    {
        private string name;
        private int age;
        private string gender;

        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public  virtual string Gender
        {
            get { return gender; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid input!");
                }
                gender = value;
            }
        }

        public  int Age
        {
            get { return age; }
            set
            {
                if (string.IsNullOrWhiteSpace(value.ToString()) || value < 0)
                {
                    throw new ArgumentException("Invalid input!");
                }
                age = value;
            }
        }

        public virtual string Name
        {
            get 
            { 
                return name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid input!");
                }
                name = value;
            }
        }

        public virtual string GetResult()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"{this.Name} {this.Age} {this.Gender}{Environment.NewLine}");
            return sb.ToString();
        }

    }

}
