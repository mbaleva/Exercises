using System;
using System.Linq;
using System.Collections.Generic;

namespace CarSalesman
{
    class Program
    {
        static void Main(string[] args)
        {
            int countEngine = int.Parse(Console.ReadLine());

            List<Engine> engines = new List<Engine>();

            for (int i = 0; i < countEngine; i++)
            {
                Engine currentEngine = new Engine();

                string[] arr = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string model = arr[0];
                int power = int.Parse(arr[1]);

                currentEngine.Model = model;
                currentEngine.Power = power;

                if (arr.Length == 3)
                {
                    string something = arr[2];

                    //2
                    //V8 - 101 220 50
                    //V4 - 33 140 28 B

                    if (char.IsDigit(something, 0))
                    {
                        currentEngine.Displacement = something;
                    }
                    else
                    {
                        currentEngine.Efficiency = something;
                    }
                }
                else if (arr.Length == 4)
                {
                    string displacement = arr[2];
                    string efficiency = arr[3];

                    currentEngine.Displacement = displacement;
                    currentEngine.Efficiency = efficiency;
                }


                engines.Add(currentEngine);
            }

            List<Car> cars = new List<Car>();

            int countCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < countCars; i++)
            {


                string[] arr = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray(); 

                Engine blu = engines.Where(x=>x.Model == arr[1]).FirstOrDefault();

                Car currentCar = new Car();

                currentCar.Engine = blu;
                currentCar.Model = arr[0];

                if (arr.Length==3)
                {
                    string something = arr[2];

                    if (char.IsDigit(something,0))
                    {
                        currentCar.Weight = something;
                    }
                    else
                    {
                        currentCar.Color = something;
                    }
                }
                else if (arr.Length ==4)
                {

                    //FordFocus V4-33 1300 Silver
                    //   0        1     2    3
                    //FordMustang V8 - 101
                    //VolkswagenGolf V4-33 Orange

                    currentCar.Weight = arr[2];
                    currentCar.Color = arr[3];
                }
                cars.Add(currentCar);
            }


            foreach (var item in cars)
            {
                Console.WriteLine($"{item.Model}:");
                Console.WriteLine($"  {item.Engine.Model}:");
                Console.WriteLine($"    Power: {item.Engine.Power}");
                Console.WriteLine($"    Displacement: {item.Engine.Displacement}");
                Console.WriteLine($"    Efficiency: {item.Engine.Efficiency}");
                Console.WriteLine($"  Weight: {item.Weight}");
                Console.WriteLine($"  Color: {item.Color}");

            }

        }
    }
}
