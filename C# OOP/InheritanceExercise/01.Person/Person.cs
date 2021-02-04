using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Person
{
    public class Person
    {
        public Person(string name,int age)
        {
            this.Name = name;
            this.Age = age;
        }

        private string name;
        private int age;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                name = value;
            }
        }
        public int Age
        {
            get
            {
                if (age>=0)
                {
                return this.age;

                }
                return 0;
            }
            set
            {
                if (age>=0)
                {
                age = value;

                }
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(String.Format("Name: {0}, Age: {1}",
                                 this.Name,
                                 this.Age));

            return sb.ToString();
        }
    }
}
