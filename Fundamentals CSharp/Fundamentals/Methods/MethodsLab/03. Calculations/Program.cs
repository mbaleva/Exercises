using System;

namespace _03._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int nums1 = int.Parse(Console.ReadLine());
            int nums2 = int.Parse(Console.ReadLine());
            Calculations(command, nums1, nums2);
        }

        static void Calculations(string command, int a, int b)
        {
            int result = 0;
            if (command == "add")
            {
                result = a + b;
                Console.WriteLine(result);
            }
            else if (command == "substract")
            {
                result = a - b;
                Console.WriteLine(result);
            }
            else if (command == "multiply")
            {
                result = a * b;
                Console.WriteLine(result);
            }
            else if (command=="divide")
            {
                result = a / b;
                Console.WriteLine(result);
            }
        }
    }
}
