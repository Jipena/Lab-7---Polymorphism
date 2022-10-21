using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_7___Polymorphism
{
    class Parallellogram : Geometri
    {
        // Fields
        public double Base;
        public double Hight;

        // Constructor
        public Parallellogram()
        {
            Base = 3;
            Hight = 6;
        }

        // Method
        public override double Area()
        {
            return Base * Hight;
        }

    }
}
