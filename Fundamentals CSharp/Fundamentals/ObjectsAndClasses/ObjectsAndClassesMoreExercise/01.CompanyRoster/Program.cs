using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CompanyRoster
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Profession> professions = new List<Profession>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] inputArr = Console.ReadLine().Split();

                if (!professions.Any(d => d.ProfessionName == inputArr[2]))
                {
                    professions.Add(new Profession(inputArr[2]));
                }

                professions.Find(d => d.ProfessionName == inputArr[2]).AddNewEmployee(inputArr[0], decimal.Parse(inputArr[1]));

            }
            Profession bestProfession = professions.OrderByDescending(d => d.TotalSalaries / d.Employees.Count()).First();

            Console.WriteLine($"Highest Average Salary: {bestProfession.ProfessionName}");

            foreach (var item in bestProfession.Employees.OrderByDescending(e => e.Salary))
            {
                Console.WriteLine($"{item.Name} {item.Salary:F2}");
            }

        }
    }
    class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public Employee(string name, decimal salary)
        {
            Name = name;
            Salary = salary;
        }
    }
    class Profession
    {
        public string ProfessionName { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();
        public decimal TotalSalaries { get; set; }

        public void AddNewEmployee(string empName, decimal empSalary)
        {
            this.TotalSalaries += empSalary;

            this.Employees.Add(new Employee(empName, empSalary));
        }

        public Profession(string departmentName)
        {
            this.ProfessionName = departmentName;
        }
    }
}
