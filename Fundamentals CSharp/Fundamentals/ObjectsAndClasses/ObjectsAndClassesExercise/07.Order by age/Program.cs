using System;
using System.Linq;
using System.Collections.Generic;

namespace _07.Order_by_age
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();


            List<Age> collection = new List<Age>();

            while (command!="End")
            {
                string[] cmdArgs = command.Split();

                Age person = new Age(cmdArgs[0],cmdArgs[1],int.Parse(cmdArgs[2]));

                collection.Add(person);
                command = Console.ReadLine();
            }

            collection = collection.OrderBy(x => x.AgeForThePerson).ToList();

            Console.WriteLine(string.Join(Environment.NewLine, collection));
        }
    }
    class Age
    {
        public Age(string name, string iD, int age)
        {
            Name = name;
            ID = iD;
            AgeForThePerson = age;
        }

        public string Name { get; set; }
        public string ID { get; set; }
        public int AgeForThePerson { get; set; }

        public override string ToString()
        {
            return $"{Name} with ID: {ID} is {AgeForThePerson} years old."; 
        }
    }
}
