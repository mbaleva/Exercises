using System;

namespace _01.DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();

            if (dataType == "int")
            {
                int num = int.Parse(Console.ReadLine());

                Console.WriteLine(num*2);
            }
            else if (dataType == "real")
            {
                double num = double.Parse(Console.ReadLine());
                double result = num * 1.5; ;
                Console.WriteLine($"{result:F2}");
            }
            else if (dataType=="string")
            {
                string text = Console.ReadLine();
                Console.WriteLine($"${text}$");
            }
        }
    }
}
