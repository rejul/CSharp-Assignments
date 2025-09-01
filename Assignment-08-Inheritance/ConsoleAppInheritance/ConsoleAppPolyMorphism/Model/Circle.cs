using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPolyMorphism.Model
{
    public class Circle: GeometricFigure
    {
        //fields
        public double Radius { get; set; }

        //accept method to get radius from user
        public override void Accept()
        {
            NoOfSides = 0; // A circle has no sides
            Console.WriteLine("Enter the radius of the circle:");
            Radius = Convert.ToDouble(Console.ReadLine());
        }
        //display method to show circle details
        public override void Display()
        {
            Console.WriteLine($"Circle - Sides: {NoOfSides}, Radius: {Radius}");
        }
        //area method to calculate area of circle
        public override double Area()
        {
            return Math.PI * Radius * Radius; // Area of circle = π * r^2
        }

    }


}

