using System;

namespace ConditionalllStatemants2
{
    class Program
    {
        static void Main(string[] args)
        {
            double budjet = double.Parse(Console.ReadLine());

            

            while (true)
            {
                string actorName = Console.ReadLine();

                if (actorName == "ACTION")
                {
                    break;
                }


                if (actorName.Length>15)
                {
                    budjet *= 0.8;
                    continue;
                }
                double salary = double.Parse(Console.ReadLine());

                budjet -= salary;

                if (budjet<0)
                {
                    break;
                }
            }
            if (budjet>0)
            {
                Console.WriteLine($"We are left with {budjet:F2} leva.");
            }
            else
            {
                //budjet<0
                Console.WriteLine($"We need {Math.Abs(budjet):F2} leva for our actors.");
            }
        }
    }
}