using System;
using System.Collections.Generic;

namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            List<Person> persons = new List<Person>();

            for (int i = 0; i < n; i++)
            {

                string[] arr = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string firstName = arr[0];
                string lastName = arr[1];
                int age = int.Parse(arr[2]);
                decimal salary = decimal.Parse(arr[3]);

                Person currentPerson = new Person(firstName,lastName,age,salary);
                persons.Add(currentPerson);
            }
            decimal percentage = decimal.Parse(Console.ReadLine());
            persons.ForEach(x => x.IncreaseSalary(percentage));
            persons.ForEach(x=>Console.WriteLine(x.ToString()));
        }
    }
}
