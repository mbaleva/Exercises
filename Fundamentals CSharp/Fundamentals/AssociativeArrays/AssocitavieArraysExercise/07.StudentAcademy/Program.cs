using System;
using System.Linq;
using System.Collections.Generic;

namespace _07.StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> grades = new Dictionary<string, List<double>>();


            for (int i = 0; i < n; i++)
            {
                string studenName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!grades.ContainsKey(studenName))
                {
                    grades.Add(studenName, new List<double>());
                }
                grades[studenName].Add(grade);


            }
            foreach (var item in grades.OrderByDescending(x => x.Value.Average()))
            {
                if (item.Value.Average()>=4.5)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value.Average():F2}");
                }
            }
        }
    }
}
