using System;
using System.Linq;
using System.Collections.Generic;

namespace RawData
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] arr = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                //ChevroletAstro 200 180 1000 fragile 1.3 1 1.5 2 1.4 2 1.7 4
                //"{model} {engineSpeed} {enginePower}
                //{cargoWeight} {cargoType} 
                //{tire1Pressure}double {tire1Age} int
                //{tire2Pressure} {tire2Age}
                //{tire3Pressure} {tire3Age} 
                //{tire4Pressure} {tire4Age}"
                Car car = new Car(arr[0],int.Parse(arr[1]),int.Parse(arr[2]),
                    int.Parse(arr[3]),arr[4],
                    double.Parse(arr[5]),int.Parse(arr[6]),
                    double.Parse(arr[7]), int.Parse(arr[8]),
                    double.Parse(arr[9]), int.Parse(arr[10]),
                    double.Parse(arr[11]), int.Parse(arr[12]));
                cars.Add(car);
            }
            string cmd = Console.ReadLine();

            List<Car> result = new List<Car>();

            if (cmd=="fragile")
            {
                result = cars.Where(x=>x.Cargo.CargoType==cmd)
                    .Where(x=>x.Tire.Any(y=>y.Pressure<1))
                    .ToList();
            }
            else
            {
                result = cars.Where(x => x.Cargo.CargoType == cmd)
                    .Where(x=>x.Engine.EnginePower>250)
                    .ToList();
            }
            foreach (var item in result)
            {
                Console.WriteLine(item.Model);
            }
        }
    }
}
