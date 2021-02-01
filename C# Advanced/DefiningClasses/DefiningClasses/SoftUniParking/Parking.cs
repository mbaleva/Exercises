using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SoftUniParking
{
    public class Parking
    {
        private List<Car> cars;
        private int capacity;
        public int Count
        {
            get
            {
                return cars.Count;
            }
        }

        public Parking(int capacity)
        {
            cars = new List<Car>(capacity);
            this.capacity = capacity;
        }
        public string AddCar(Car car)
        {
            if (cars.Any(x => x.RegistrationNumber == car.RegistrationNumber))
            {
                return "Car with that registration number, already exists!";

            }
            else if (cars.Count >= capacity)
            {
                return "Parking is full!";

            }
            else
            {
                cars.Add(car);
                return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
            }
        }
        public string RemoveCar(string RegistrationNumber)
        {
            bool isContainsThatCar = cars.Any(x => x.RegistrationNumber == RegistrationNumber);

            if (isContainsThatCar)
            {
                int index = cars.FindIndex(x => x.RegistrationNumber == RegistrationNumber);
                cars.Remove(cars[index]);
                return $"Successfully removed {RegistrationNumber}";
            }
            else
            {
                return "Car with that registration number, doesn't exist!";
            }

        }
        public Car GetCar(string RegistrationNumber)
        {
            int index = cars.FindIndex(x => x.RegistrationNumber == RegistrationNumber);
            Car car = cars[index];
            return car;
        }
        public void RemoveSetOfRegistrationNumber(List<string> RegistrationNumbers)
        {
            foreach (string registrationNumber in RegistrationNumbers)
            {
                if (cars.Any(c => c.RegistrationNumber == registrationNumber))
                {
                    Car carToRemove = cars.FirstOrDefault(c => c.RegistrationNumber == registrationNumber);

                    cars.Remove(carToRemove);
                }
            }
        }
    }
}
