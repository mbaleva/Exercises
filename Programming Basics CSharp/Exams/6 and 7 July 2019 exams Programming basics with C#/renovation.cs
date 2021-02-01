using System;

namespace ConditionalllStatemants2
{
    class Program
    {
        static void Main(string[] args)
        {
            double height = int.Parse(Console.ReadLine());
            double length = int.Parse(Console.ReadLine());
            double percentage = int.Parse(Console.ReadLine());

            double space = height * length * 4;
            space = Math.Ceiling(space-(space /100*percentage));

            string command = Console.ReadLine();

            while (command!="Tired!")
            {
                double litersPaint = double.Parse(command);
                space -= litersPaint;
                if (space<=0)
                {
                    break;
                }
                command = Console.ReadLine();
            }
            if (command == "Tired!")
            {
                Console.WriteLine($"{space} quadratic m left.");
                
            }
            else if (space < 0)
            {
                Console.WriteLine($"All walls are painted and you have {Math.Abs(space)} l paint left!");
                
            }
            else if (space == 0)
            {
                Console.WriteLine($"All walls are painted! Great job, Pesho!");
                
            }

        }
    }
}