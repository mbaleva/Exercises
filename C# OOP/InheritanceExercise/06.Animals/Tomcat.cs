using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    class Tomcat : Animal, IProduceSound
    {
        public Tomcat(string name, int age) : base(name, age, "Male")
        {
        }

        public string ProduceSound()
        {
            return "MEOW";
        }

        public override string GetResult()
        {
            return base.GetResult() + ProduceSound();
        }
    }
}
