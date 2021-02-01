using System;
using System.Collections.Generic;
using System.Text;

namespace _03.GenericSwapMethodStrings
{
    class IDK<T>
    {
        public IDK(List<T> values)
        {
            this.Values = values;
        }
        public List<T> Values { get; set; } = new List<T>();

        public void SwapElements(int firstIndex, int secondIndex)
        {
            if (firstIndex>=0&&firstIndex<=Values.Count
                &&secondIndex>=0&&secondIndex<=Values.Count)
            {

            T temp = Values[firstIndex];
            Values[firstIndex] = Values[secondIndex];
            Values[secondIndex] = temp;
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (T item in Values)
            {
                sb.AppendLine($"{item.GetType()}: {item}");
            }
            return sb.ToString();
        }
    }
}
