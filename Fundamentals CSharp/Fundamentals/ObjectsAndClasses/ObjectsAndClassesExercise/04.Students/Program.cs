using System;
using System.Linq;
using System.Collections.Generic;

namespace _04.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                string[] studentsInfo = Console.ReadLine().Split();

                Student student = new Student(studentsInfo[0],
                    studentsInfo[1],double.Parse(studentsInfo[2]));

                students.Add(student);
            }
            students = students.OrderByDescending(a=>a.Grade).ToList();
           Console.WriteLine(string.Join(Environment.NewLine, students));
            
        }
    }
    public class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} {Grade:F2}";
        }
    }
}
