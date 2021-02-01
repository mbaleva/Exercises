using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    class Car
    {
        public Car(string model, int engineSpeed, int enginePower,
            int cargoWeight, string cargoType, 
            double pressure1, int age1,
            double pressure2, int age2,
            double pressure3, int age3,
            double pressure4, int age4)
        {
            Model = model;
            Cargo = new Cargo(cargoWeight, cargoType);
            Engine = new Engine(engineSpeed, enginePower);
            Tire = new Tire[4];
            Tire[0] = new Tire(pressure1, age1);
            Tire[1] = new Tire(pressure2, age2);
            Tire[2] = new Tire(pressure3, age3);
            Tire[3] = new Tire(pressure4, age4);
        }

        public string Model { get; set; }

        public Cargo Cargo { get; set; }
        public Engine Engine { get; set; }
        public Tire[] Tire { get; set; }
    }
}
