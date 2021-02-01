using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.RawData
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] arr = Console.ReadLine().Split();

                //ChevroletAstro 200 180 1000 fragile

                Car car = new Car(arr[0]
                        ,int.Parse(arr[1])
                        ,int.Parse(arr[2])
                        ,int.Parse(arr[3])
                        ,arr[4]);
                cars.Add(car);
            }
            string command = Console.ReadLine();

            if (command== "fragile")
            {
                cars.Where(x => x.CargoType == command)
                    .Where(y => y.CrgoWeight < 1000)
                    .ToList()
                    .ForEach(z=>Console.WriteLine(z.Model));
            }
            else if (command== "flamable")
            {
                cars.Where(x => x.CargoType == command)
                    .Where(x => x.EnginePower > 250)
                    .ToList()
                    .ForEach(x => Console.WriteLine(x.Model));
            }
        }
    }
    class Car
    {
        public Car(string model, int engineSpeed, int enginePower, int crgoWeight, string cargoType)
        {
            Model = model;
            EngineSpeed = engineSpeed;
            EnginePower = enginePower;
            CrgoWeight = crgoWeight;
            CargoType = cargoType;
        }

        public string Model { get; set; }
        public int EngineSpeed { get; set; }
        public int EnginePower { get; set; }
        public int CrgoWeight { get; set; }
        public string CargoType { get; set; }
      
    }
}
