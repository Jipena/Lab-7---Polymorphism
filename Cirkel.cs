using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_7___Polymorphism
{
    class Cirkel : Geometri
    {
        // Fields
        public double Radius;
        public double π = 3.14;

        // Constructor
        public Cirkel()
        {
            Radius = 2;
        }

        // Method
        public override double Area()
        {
            return π * Radius * Radius;
        }
    }
}
