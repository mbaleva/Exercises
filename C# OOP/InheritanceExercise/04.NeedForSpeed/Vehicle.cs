﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Vehicle
    {
        public Vehicle(int horsePower,double fuel)
        {
            this.Fuel = fuel;
            this.HorsePower = horsePower;
        }
        private const double DefaultFuelConsumption = 1.25;
        public virtual double FuelConsumption 
        {
            get
            {
                return DefaultFuelConsumption;
            }
        }

        public double Fuel 
        {
            get;
            set;
        }
        public int HorsePower { get; set; }

        public virtual void Drive(double kilometers)
        {
            this.Fuel -= kilometers * FuelConsumption;
        }
    }
}