﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace _06.Vehicle_catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> catalogue = new List<Vehicle>();

            string command = Console.ReadLine();

            while (command!="End")
            {
                string[] cmdArgs = command.
                                   Split(' ', 
                                   StringSplitOptions.RemoveEmptyEntries);

                string type = cmdArgs[0].ToLower();
                string model = cmdArgs[1];
                string color = cmdArgs[2].ToLower();
                int hp = int.Parse(cmdArgs[3]);

                Vehicle currentVehicle = new Vehicle(type, model, color, hp);
                catalogue.Add(currentVehicle);
                command = Console.ReadLine();
            }

            string secondCommand = Console.ReadLine();

            while (secondCommand!="Close the Catalogue")
            {
                string modelType = secondCommand;

                Vehicle printCar = catalogue.
                    First(x => x.Model == modelType);

                Console.WriteLine(printCar);

                secondCommand = Console.ReadLine();

            }
            List<Vehicle> onlyCars = catalogue.Where(x => x.Type == "car").ToList();
            List<Vehicle> onlyTrucks = catalogue.Where(x => x.Type == "truck").ToList();

            double totalCarsHorsePower = onlyCars.Sum(x => x.HorsePower);
            double totalTrucksHorsePower = onlyTrucks.Sum(x => x.HorsePower);

            double averageCarsHp = 0.00;
            double averageTrucksHp = 0.00;

            if (onlyCars.Count>0)
            {
                averageCarsHp = totalCarsHorsePower / onlyCars.Count;
            }
            if (onlyTrucks.Count > 0)
            {
                averageTrucksHp = totalTrucksHorsePower / onlyTrucks.Count;
            }
            Console.WriteLine($"Cars have average horsepower of: " +
                $"{averageCarsHp:F2}.");
            Console.WriteLine($"Trucks have average horsepower of: " +
                $"{averageTrucksHp:F2}.");
        }
    }
    class Vehicle
    {
        public Vehicle(string type, string model,string color,int horsePower)
        {
            Type = type;
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Type: {(Type == "car" ? "Car" : "Truck")}");
            sb.AppendLine($"Model: {Model}");
            sb.AppendLine($"Color: {Color}");
            sb.AppendLine($"Horsepower: {HorsePower}");

            return sb.ToString().TrimEnd();
        }

    }
}
