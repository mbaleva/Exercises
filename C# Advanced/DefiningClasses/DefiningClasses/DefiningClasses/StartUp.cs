using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Person> peoples = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] arr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string name = arr[0];
                int age = int.Parse(arr[1]);

                Person person = new Person(name,age);

                peoples.Add(person);
            }
            peoples = peoples.OrderBy(x=>x.Name).Where(x => x.Age > 30).ToList();


            foreach (var people in peoples)
            {
                Console.WriteLine($"{people.Name} - {people.Age}");
            }
        }
    }
}
