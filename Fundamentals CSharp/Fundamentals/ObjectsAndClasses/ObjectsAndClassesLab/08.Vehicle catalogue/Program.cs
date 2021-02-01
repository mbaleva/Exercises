using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Vehicle_catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            var catalog = new Catalog();
            catalog.truck = new List<Trucks>();
            catalog.car = new List<Cars>();
            while (true)
            {
                List<string> data = Console.ReadLine().Split("/").ToList();

                if (data[0] == "end")
                {
                    break;
                }
                else if (data[0] == "Truck")
                {
                    Trucks truck = new Trucks();
                    truck.brand = data[1];
                    truck.model = data[2];
                    truck.weight = data[3];
                    catalog.truck.Add(truck);
                }
                else if (data[0] == "Car")
                {
                    Cars car = new Cars();
                    car.brand = data[1];
                    car.model = data[2];
                    car.housePower = data[3];
                    catalog.car.Add(car);
                }
            }
            if (catalog.car.Count>0)
            {
                Console.WriteLine("Cars:");
              

                foreach (var car in catalog.car.OrderBy(c => c.brand))
                {
                    Console.WriteLine($"{car.brand}: {car.model} - {car.housePower}hp");

                }
            }
            if (catalog.truck.Count>0)
            {
                Console.WriteLine($"Trucks:");

                foreach (var truck in catalog.truck.OrderBy(t=>t.brand))
                {
                    Console.WriteLine($"{truck.brand}: {truck.model} - {truck.weight}kg");
                }
            }
        }
    }
    public class Cars
    {
        public string brand;
        public string model;
        public string housePower;
    }
    public class Trucks
    {
        public string brand;
        public string model;
        public string weight;
    }
    public class Catalog
    {
        public List<Cars> car;
        public List<Trucks> truck;
    }
}
