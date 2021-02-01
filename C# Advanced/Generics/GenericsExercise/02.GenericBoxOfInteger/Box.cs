using System;
using System.Collections.Generic;
using System.Text;

namespace _02.GenericBoxOfInteger
{
    class Box
    {
        public int Number { get; set; }
        public Box(int number)
        {
            this.Number = number;
        }
        public override string ToString()
        {
            return $"System.Int32: {Number}";
        }
    }
}
