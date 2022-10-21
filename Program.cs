using System;

namespace Lab_7___Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Geometri square = new Fyrkant();
            Console.WriteLine("Area Fyrkant : " + square.Area());

            Geometri circle = new Cirkel();
            Console.WriteLine("Area Cirkel : " + circle.Area());

            Geometri rectangle = new Rektangel();
            Console.WriteLine("Area Rektangel : " + rectangle.Area());

            Geometri parallelogram = new Parallellogram();
            Console.WriteLine("Area Parallellogram : " + parallelogram.Area());

            Geometri ellipse = new Ellips();
            Console.WriteLine("Area Ellips : " + ellipse.Area());

            Console.ReadLine();
        }
    }
}  
