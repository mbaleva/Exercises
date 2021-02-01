using System;
using System.Collections.Generic;
using System.Text;

namespace _07.Tuple
{
    public class Tuple<TFirst,TSecond>
    {
        public TFirst Item1 { get; set; }
        public TSecond Item2 { get; set; }

        public Tuple(TFirst item1, TSecond item2)
        {
            this.Item1 = item1;
            this.Item2 = item2;
        }
        public override string ToString()
        {
            return $"{Item1} -> {Item2}";
        }
    }
}
