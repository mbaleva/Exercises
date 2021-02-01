using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Snowwhite
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pesho> Lollipop = new List<Pesho>();


            string bum = string.Empty;

            while ((bum=Console.ReadLine())!="Once upon a time")
            {
                string[] arr = bum.Split(" <:> ").ToArray();

                string name = arr[0];
                string color = arr[1];
                int value = int.Parse(arr[2]);

                Pesho repeat = Lollipop.Find(x => x.Name == name && x.Color == color);

                if (repeat==null)
                {
                    Pesho newPesho = new Pesho(name, color, value);
                    Lollipop.Add(newPesho);
                }
                else
                {
                    repeat.Value = Math.Max(repeat.Value, value);
                }
            }
            foreach (var item in Lollipop
                .OrderByDescending(x => x.Value)
                .ThenByDescending(x => Lollipop.Count(y => y.Color == x.Color)))
            {
                Console.WriteLine($"({item.Color}) {item.Name} <-> {item.Value}");
            }
        }
    }
    class Pesho
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Value { get; set; }

        public Pesho(string name, string color, int value)
        {
            Name = name;
            Color = color;
            Value = value;
        }
    }
}
