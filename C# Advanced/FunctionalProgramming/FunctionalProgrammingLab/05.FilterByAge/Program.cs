using System;
using System.Linq;

namespace _05.FilterByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            People[] people = new People[n];
            for (int i = 0; i < n; i++)
            {
                string[] arr = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                people[i] = new People()
                {
                    Name = arr[0],
                    Age = int.Parse(arr[1])
                };

            }
            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();


            Func<People, bool> conditionDelegate = GetCondition(condition,age);
            Action<People> formatDelegate = GetFormat(format);
            foreach (var item in people)
            {
                if (conditionDelegate(item))
                {
                    formatDelegate(item);
                }
            }
        }
        static Action<People> GetFormat(string format)
        {
            switch (format)
            {
                case "name":
                    return x => { Console.WriteLine($"{x.Name}"); };
                case "age":
                    return x => { Console.WriteLine($"{x.Age}"); };
                case "name age":
                    return x => { Console.WriteLine($"{x.Name} - {x.Age}"); };

                default:
                    return null;
                    
            }
        }
        static Func<People, bool> GetCondition(string condition,int age) 
        {
            switch (condition)
            {
                case "younger": return p => p.Age < age;
                case "older": return p => p.Age >= age;

                default:
                    return null;


                    
            }
        }

    }
    class People
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
