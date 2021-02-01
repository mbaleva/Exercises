using System;
using System.Diagnostics.CodeAnalysis;

namespace ConditionalllStatemants2
{
    class Program
    {
        static void Main(string[] args)
        {
            int countFilms = int.Parse(Console.ReadLine());
            double maxRatting = double.MinValue;
            double minRatting = double.MaxValue;
            double sum = 0.00;
            string maxFIlm = string.Empty;
            string minFIlm = string.Empty;

            for (int i = 1; i <= countFilms; i++)
            {
                string filmName = Console.ReadLine();
                double ratting = double.Parse(Console.ReadLine());

                if (ratting>maxRatting)
                {
                    maxRatting = ratting;
                    maxFIlm = filmName;
                }
                if (ratting<minRatting)
                {
                    minRatting = ratting;
                    minFIlm = filmName;
                }
                sum += ratting;
            }
            double averageRatting = sum / countFilms;
            Console.WriteLine($"{maxFIlm} is with highest rating: {maxRatting:F1}");
            Console.WriteLine($"{minFIlm} is with lowest rating: {minRatting:F1}");
            Console.WriteLine($"Average rating: {averageRatting:F1}");
          
        }
    }
}

