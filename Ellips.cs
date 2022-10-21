using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_7___Polymorphism
{
    class Ellips : Geometri
    {
         // Fields
        public double RadiusA;
        public double RadiusB;
        public double π = 3.14;

        // Constructor
        public Ellips()
        {
            RadiusA = 4;
            RadiusB = 2;
        }

        // Method
        public override double Area()
        {
            return π * RadiusA * RadiusB;
        }

    }
}
