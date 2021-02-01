using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Students_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string conditionToBreakTheLoop = Console.ReadLine();

            List<Students> students = new List<Students>();

            while (conditionToBreakTheLoop != "end")
            {
                string[] command = conditionToBreakTheLoop.Split();

                string firstName = command[0];
                string lastName = command[1];
                int age = int.Parse(command[2]);
                string town = command[3];


                if (IsStudentExisting(students, firstName, lastName))
                {

                    Students student = GetStudent(students, firstName, lastName, age);
                }
                else
                {
                    Students student = new Students()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        Hometown = town,

                    };
                    students.Add(student);
                }


                conditionToBreakTheLoop = Console.ReadLine();
            }
            string filterCity = Console.ReadLine();
            List<Students> filteredStudents = students.Where(s => s.Hometown == filterCity).ToList();

            foreach (Students student in filteredStudents)
            {

                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }
        static bool IsStudentExisting(List<Students> students, string firstName, string lastName)
        {
            foreach (Students student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }
            return false;
        }
        static Students GetStudent(List<Students> students, string firstName, string lastName, int age)
        {
            Students existingStudent = null;
            foreach (Students student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {

                    existingStudent = student;
                    existingStudent.Age = age;
                }
            }
            return existingStudent;
        }
    }
    public class Students
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Hometown { get; set; }
    }
}
