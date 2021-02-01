using System;

namespace ConditionalllStatemants2
{
    class Program
    {
        static void Main(string[] args)
        {

            double ASCIIsum = 0.00;
            double maxSum = double.MinValue;
            string favouriteFilm = string.Empty;
            int counter = 0;

            while (true)
            {
                string filmName = Console.ReadLine();
                counter++;
                if (filmName == "STOP")
                {
                    Console.WriteLine($"The best movie for you is {favouriteFilm} with {maxSum} ASCII sum.");
                    Environment.Exit(0);
                }
                if (counter == 7)
                {
                    Console.WriteLine($"The limit is reached.");
                    Console.WriteLine($"The best movie for you is {favouriteFilm} with {maxSum} ASCII sum.");
                    Environment.Exit(0);
                }

                for (int i = 0; i < filmName.Length; i++)
                {
                    int letter = (int)filmName[i];

                    if (char.IsUpper(filmName[i]))
                    {
                        ASCIIsum += letter - filmName.Length;
                    }
                    else if (char.IsLower(filmName[i]))
                    {
                        ASCIIsum += letter - filmName.Length*2;
                    }
                    else
                    {
                        ASCIIsum += letter;
                    }
                }
                if (ASCIIsum > maxSum)
                {
                    maxSum = ASCIIsum;
                    favouriteFilm = filmName;
                }
                ASCIIsum = 0;

            }
        }
    }
}