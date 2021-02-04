using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    class Kitten : Animal, IProduceSound
    {
        public Kitten(string name, int age) : base(name, age, "Female")
        {
        }


        public string ProduceSound()
        {
            return "Meow";
        }

        public override string GetResult()
        {
            return base.GetResult() + ProduceSound();
        }
    }
}
