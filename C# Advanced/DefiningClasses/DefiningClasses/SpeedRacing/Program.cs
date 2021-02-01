using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] arr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = arr[0];
                double fuelAmount = double.Parse(arr[1]);
                double fuelPerOneKm = double.Parse(arr[2]);

                Car currentCar = new Car(model, fuelAmount, fuelPerOneKm);

                cars.Add(currentCar);
            }

            string command = string.Empty;

            while ((command=Console.ReadLine())!="End")
            {
                string[] splitted = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string carModel = splitted[1];
                double travelledDistance = double.Parse(splitted[2]);

                Car car = cars.FirstOrDefault(x=>x.Model==carModel);

                car.Drive(travelledDistance);
            }
            foreach (var item in cars)
            {
                Console.WriteLine($"{item.Model} {item.FuelAmount:F2} {item.TravelledDistance}");
            }
        }
    }
}
