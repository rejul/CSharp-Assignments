using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPolyMorphism.Model
{
    public class Square: GeometricFigure
    {
        public int Side { get; set; }

        //overriding the Accept method to accept side length

        public override void Accept()
        {
            NoOfSides = 4; // A square has 4 sides
            Console.WriteLine("Enter the length of the side:");
            Side = Convert.ToInt32(Console.ReadLine());
        }
        public override void Display()
        {
            Console.WriteLine($"Square - Sides: {NoOfSides}, Side Length: {Side}");
        }
        public override double Area()
        {
            return Side * Side; // Area of square = side^2
        }

    }
}
