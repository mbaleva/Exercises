using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceLab
{
    class Student : Person
    {
        public Student(string schoolName, string name,int age) 
            : base(name,age)
        {
          
            this.SchoolName = schoolName;
            Console.WriteLine("In the person constructor");
        }
        public string SchoolName { get; set; }
    }
}
