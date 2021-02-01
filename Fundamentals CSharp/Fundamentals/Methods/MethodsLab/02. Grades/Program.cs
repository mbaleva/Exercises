using System;

namespace _02._Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double grades = double.Parse(Console.ReadLine());

            Grades(grades);
        }

        static void Grades(double n)
        {
            if (n>=2&&n<=2.99)
            {
                Console.WriteLine("Fail");
            }
            else if (n>=3&&n<=3.49)
            {
                Console.WriteLine("Poor");
            }
            else if (n >= 3.5 && n <= 4.49)
            {
                Console.WriteLine("Good");
            }
            else if (n >= 4.5 && n <= 5.49)
            {
                Console.WriteLine("Very good");
            }
            else if (n>=5.5&&n<=6)
            {
                Console.WriteLine("Excellent");
            }
        }
    }
}
