using System;
using System.Linq;
using System.Collections.Generic;

namespace _06.Courses
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Dictionary<string, List<string>> course = new Dictionary<string, List<string>>();

            string command = Console.ReadLine();

            while (command!="end")
            {
                string[] arr = command
                              .Split(" : ");

                string courseName = arr[0];
                string studentName = arr[1];

                if (!course.ContainsKey(courseName))
                {
                    course.Add(courseName, new List<string>());
                    
                }
                course[courseName].Add(studentName);

                command = Console.ReadLine();
            }

            foreach (var item in course.OrderByDescending(x=>x.Value.Count))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");

                foreach (var koza in item.Value.OrderBy(x=>x))
                {
                    Console.WriteLine($"-- {koza}");
                }
            }
        }
    }
}
