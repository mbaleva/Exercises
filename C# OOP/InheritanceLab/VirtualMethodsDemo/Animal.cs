using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualMethodsDemo
{
    public class Animal
    {
        public virtual void Eat()
        {
            Console.WriteLine("I am eating buum");
        }
    }
}
