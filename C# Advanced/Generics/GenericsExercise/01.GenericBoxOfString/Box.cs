using System;
using System.Collections.Generic;
using System.Text;

namespace _01.GenericBoxOfString
{
    class Box
    {
        public string Strings { get; set; }
        public Box(string strings)
        {
            Strings = strings;
        }

        public override string ToString()
        {
            return $"System.String: {Strings}";
        }
    }
}
