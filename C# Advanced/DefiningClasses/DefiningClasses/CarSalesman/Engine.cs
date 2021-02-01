﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    class Engine
    {
        private string model;
        private int power;
        private string displacement = "n/a";
        private string efficiency = "n/a";

        public string Model 
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }
        public int Power 
        {
            get
            {
                return power;
            }
            set
            {
                power = value;
            }
        }
        public string Displacement 
        {
            get
            {
                return displacement;
            }
            set
            {
                displacement = value;
            }
        }
        public string Efficiency 
        {
            get
            {
                return efficiency;
            }
            set
            {
                efficiency = value;
            }
        }


    }
}