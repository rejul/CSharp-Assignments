using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCoordinate.Model
{
    public class Rectangle : Shape
    {
        //fields
        public double XCoordinate { get; set; }
        private double YCoordinate { get; set; }

        //Default constructor
        public Rectangle()
        {
            XCoordinate = 0;
            YCoordinate = 0;
        }

        //parameterized constructor
        public Rectangle(double x, double y)
        {
            XCoordinate = x;
            YCoordinate = y;
        }

        //method to set X coordinate
        public void SetXCoordinate(double x)
        {
            XCoordinate = x;
        }

        //method to set Y coordinate
        public void SetYCoordinate(double y)
        {
            YCoordinate = y;
        }


        //method to calculate area
        public override double GetArea()
        {
            return XCoordinate * YCoordinate;
        }

        //method to display data
        public override void Display()
        {
            Console.WriteLine($"Rectangle with X Coordinate: {XCoordinate} and Y Coordinate: {YCoordinate} has an area of {GetArea()}");
        }



    }

}
