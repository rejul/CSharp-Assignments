using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPolyMorphism.Model
{
    public class Rectangle : GeometricFigure

    {
        public double Length { get; set; }
        public double Breadth { get; set; }



        public override void Accept()
        {
            NoOfSides = 4;
            Console.WriteLine("Enter the Length:");
            Length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Breadth:");
            Breadth = Convert.ToDouble(Console.ReadLine());


        }
        public override void Display()
        {
            Console.WriteLine($"Rectangle -Sides : {NoOfSides},length : {Length}, breadth : {Breadth}");
        }

        public override double Area()
        {
            return Length * Breadth;
        }
    }
}