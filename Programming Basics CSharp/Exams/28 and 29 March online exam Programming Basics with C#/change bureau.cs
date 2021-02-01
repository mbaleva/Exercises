using System;


namespace NestedLoopsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitcoins = int.Parse(Console.ReadLine());
            double chineeseCount = double.Parse(Console.ReadLine());
            double commission = double.Parse(Console.ReadLine());

            double bitcoinsMoneyInBGN = bitcoins * 1168;
            double chineeseTotalMoney = chineeseCount * 0.15;
            double USD = chineeseTotalMoney * 1.76;
            double moneyWithoutCommissionInBGN = bitcoinsMoneyInBGN + USD;
            double moneyWithoutCommissionInEuro = moneyWithoutCommissionInBGN / 1.95;
            double totalMoney = moneyWithoutCommissionInEuro * commission / 100;
            double totalMoney1 = moneyWithoutCommissionInEuro - totalMoney;
            Console.WriteLine($"{totalMoney1:F2}");
            


        }
    }
}
