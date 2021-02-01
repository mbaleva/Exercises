using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    class Cargo
    {
        public Cargo(int cargoWeight, string cargoType)
        {
            CargoType = cargoType;
            CargoWeight = cargoWeight;
        }

        public string CargoType { get; set; }
        public int CargoWeight { get; set; }
    }
}
