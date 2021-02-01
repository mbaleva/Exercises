using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

            List<Tire[]> tires = new List<Tire[]>();

            string command = Console.ReadLine();

            while (command != "No more tires")
            {
                string[] arr = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                var currTires = new Tire[4]
                {
                    new Tire(int.Parse(arr[0]), double.Parse(arr[1])),
                    new Tire(int.Parse(arr[2]), double.Parse(arr[3])),
                    new Tire(int.Parse(arr[4]), double.Parse(arr[5])),
                    new Tire(int.Parse(arr[6]), double.Parse(arr[7]))
                };

                tires.Add(currTires);

                command = Console.ReadLine();
            }

            List<Engine> engines = new List<Engine>();

            command = Console.ReadLine();

            while (command != "Engines done")
            {
                string[] arr = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                var engine = new Engine(int.Parse(arr[0]), double.Parse(arr[1]));
                engines.Add(engine);

                command = Console.ReadLine();
            }

            List<Car> cars = new List<Car>();

            command = Console.ReadLine();

            while (command != "Show special")
            {
                string[] arr = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string make = arr[0];
                string model = arr[1];
                int year = int.Parse(arr[2]);
                double fuelQuantity = double.Parse(arr[3]);
                double fuelCapacity = double.Parse(arr[4]);
                int engineIndex = int.Parse(arr[5]);
                int tireIndex = int.Parse(arr[6]);

                if ((engineIndex >= 0 && engineIndex < engines.Count) && (tireIndex >= 0 && tireIndex < tires.Count))
                {
                    var car = new Car(make, model, year, fuelQuantity, fuelCapacity, engines[engineIndex], tires[tireIndex]);
                    cars.Add(car);
                }

                command = Console.ReadLine();
            }

            cars = cars.Where(x => x.Year >= 2017 && x.Engine.HorsePower > 330 && x.Tires.Sum(y => y.Pressure) >= 9 && x.Tires.Sum(y => y.Pressure) <= 10).ToList();

            if (cars.Any())
            {
                foreach (var car in cars)
                {
                    car.Drive(20);
                    Console.WriteLine(car.WhoAmI());
                }
            }
        }
    }
}
