using ConsoleAppShape.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppShapeVolume.Model
{
    public class Cylinder : Shape
    {
        //fields
        public double Radius { get; set; }
        public double Height { get; set; }

        //default constructor

        //parameterized constructor

        // Method to accept radius and height

        public override void  Accept()
        {
            Console.WriteLine("Enter Radius of Cylinder:");
            Radius = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Height of Cylinder:");
            Height = double.Parse(Console.ReadLine());
        }

        // Method to calculate volume of cylinder
        public override double Volume()
        {
            return Math.PI * Radius * Radius * Height;
        }

    }
}
