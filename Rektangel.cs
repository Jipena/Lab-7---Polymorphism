using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_7___Polymorphism
{
    class Rektangel : Geometri
    {
        // Fields
        public double Base;
        public double Hight;

        // Constructor
        public Rektangel()
        {
            Base = 2;
            Hight = 8;
        }

        // Method
        public override double Area()
        {
            return Base * Hight;
        }

    }
}
