using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppShape.Model
{
    public class Cube : Shape
    {
        //fields
        public double SideLength { get; set; }

        //default constructor

        public Cube() : base()
        {
            SideLength = 10; // Default side length
        }

        //parameterized constructor

        //method to accept side length
        public override void Accept()
        {
            Console.WriteLine("Enter Side Length of Cube:");
            SideLength = double.Parse(Console.ReadLine());
        }

        //override method to calculate volume
        public override double Volume()
        {
            return Math.Pow(SideLength, 3); // Volume of a cube = side^3
        }


    }
}
