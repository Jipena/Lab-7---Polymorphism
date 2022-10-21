using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_7___Polymorphism
{
    class Fyrkant : Geometri
    {
        // Fields
        public double Side;

        // Constructor
        public Fyrkant()
        {
            Side = 5;
        }

        // Method
        public override double Area()
        {
            return Side * Side;
        }
    }
}
