using System;

namespace InheritanceLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Student peshko = new Student("zlatarov","peshko",18);
            Console.WriteLine(peshko.SchoolName);
            Console.WriteLine(peshko.Name);
            Console.WriteLine(peshko.Age);
        }
    }
}
