using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPolymorphism.Model
{
    public class Rectangle : GeometricFigure
    {
        //fields/attributes/properties
        public double Length { get; set; }
        public double Breadth { get; set; }

        public Rectangle():base()
        {
            
        }

        //Accept
        public override void Accept()
        {
            NoOfSides = 4;
            Console.WriteLine("Enter Length:");
            Length = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Breadth:");
            Breadth = double.Parse(Console.ReadLine());
        }

        //override Method to display
        public override void Display()
        {
            Console.WriteLine($"Rectangle - Sides: {NoOfSides}, Length :{Length} , Breadth : {Breadth}");
        }

        //override Method to calculate area
        public override double Area()
        {
            return Length * Breadth;
        }

    }
}
