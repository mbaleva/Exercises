using System;
using System.Collections.Generic;

namespace _05._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Students> filtratedStudents = new List<Students>();
            while (true)
            {
                string conditionToStop = Console.ReadLine();

                if (conditionToStop=="end")
                {
                    break;
                }

                string[] command = conditionToStop
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                Students gosho = new Students();

                string firstName = command[0];
                string lastName = command[1];
                int age = int.Parse(command[2]);
                string hometown = command[3];

                gosho.FirstName = firstName;
                gosho.LastName = lastName;
                gosho.Age = age;
                gosho.Hometown = hometown;

                filtratedStudents.Add(gosho);
            }
            string lastCommand = Console.ReadLine();

            foreach (Students item in filtratedStudents)
            {
                if (item.Hometown == lastCommand)
                {
                    Console.WriteLine($"{item.FirstName} {item.LastName} is {item.Age} years old.");
                }
            }
        }
    }
    public class Students
    {
        public string FirstName{get;set;}
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Hometown { get; set; }
    }
}
