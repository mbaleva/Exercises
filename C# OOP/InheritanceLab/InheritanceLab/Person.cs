using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceLab
{
    class Person
    {
        public Person(string name,int age)
        {
            this.Name = name;
            this.Age = age;
            Console.WriteLine("Base constructor");
        }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
