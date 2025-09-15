using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPolymorphism.Model
{
    public class Square : GeometricFigure
    {
        //fields
        public double Side { get; set; }

        //default constructor
        public Square() : base()
        {
        }

        //Accept method to get input from user

        public override void Accept()
        {
            NoOfSides = 4; //Square always has 4 sides
            Console.WriteLine("Enter Side Length:");
            Side = double.Parse(Console.ReadLine());
        }

        //override Method to display

        public override void Display()
        {
            Console.WriteLine($"Square - Sides: {NoOfSides}, Side Length: {Side}");
        }

        //override Method to calculate area

        public override double Area()
        {
            return Side * Side; 
        }

    }

}
