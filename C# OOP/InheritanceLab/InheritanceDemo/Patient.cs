using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceDemo
{
    class Patient : Person
    {
        protected float weight;
        public void Method()
        {
            double weight = 0.5d;
            this.weight = 0.6f;
            base.weight = 1;
            //base => base class
            //this => instance of class (whole object)

        }

    }
}
