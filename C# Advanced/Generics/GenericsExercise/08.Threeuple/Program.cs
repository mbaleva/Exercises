using System;

namespace _08.Threeuple
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine().Split();

            string fullName = $"{firstArr[0]} {firstArr[1]}";
            string adress = firstArr[2];
            string town = string.Empty;
            if (firstArr.Length==4)
            {
                town = firstArr[3];
            }
            else
            {
            town = $"{firstArr[3]} {firstArr[4]}";
                    
            }

            Threeuple<string, string, string> first = new Threeuple<string, string, string>
                (fullName, adress, town);

            string[] secondArr = Console.ReadLine()
                .Split();
            string name = secondArr[0];
            int liters = int.Parse(secondArr[1]);
            string thirdParam = string.Empty;
            if (secondArr[2]=="drunk")
            {
                thirdParam = "True";
            }
            else
            {
                thirdParam = "False";
            }

            Threeuple<string, int, string> second = new Threeuple<string, int, string>
                (name,liters,thirdParam);

            string[] thirdArr = Console.ReadLine()
                .Split();

            string nameAgain = thirdArr[0];
            double accountBalance = double.Parse(thirdArr[1]);
            string bankName = thirdArr[2];

            Threeuple<string, double, string> third = new Threeuple<string, double, string>
                (nameAgain, accountBalance, bankName);

            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine(third);
        }
    }
}
