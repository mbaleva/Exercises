using System;

namespace SimpleOperationsAndMoreCalculationsMoreExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            bool isFirstConditionTrue = (x1 == x||x2==x)&&(y>=y1&&y<=y2);
            bool isSecondConditionTrue = (y1 == y||y2==y)&&(x>=x1&&x<=x2);

            if (isFirstConditionTrue||isSecondConditionTrue)
            {
                Console.WriteLine($"Border");
            }
            else
            {
                Console.WriteLine($"Inside / Outside");
            }
        }
    }
}