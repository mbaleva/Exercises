using System;
using System.Linq;

namespace _07.Tuple
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] firstArr = Console.ReadLine()
                .Split();
            string fullName = $"{firstArr[0]} {firstArr[1]}";
            string adress = firstArr[2];

            Tuple<string, string> first = new Tuple<string, string>(fullName, adress);

            string[] secondArr = Console.ReadLine()
                .Split();

            string name = secondArr[0];
            int liters = int.Parse(secondArr[1]);

            Tuple<string, int> second = new Tuple<string, int>(name,liters);

            string[] thirdArr = Console.ReadLine()
                .Split();

            int integer = int.Parse(thirdArr[0]);
            double floatingPointNum = double.Parse(thirdArr[1]);

            Tuple<int, double> third = new Tuple<int, double>(integer,floatingPointNum);

            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine(third);

        }
    }
}
