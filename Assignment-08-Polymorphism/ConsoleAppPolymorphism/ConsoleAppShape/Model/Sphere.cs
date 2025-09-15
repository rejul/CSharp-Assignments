using ConsoleAppShape.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppShapeVolume.Model
{
    public class Sphere : Shape
    {
        //fields
        public double Radius { get; set; }

        //default constructor

        //method to accept radius

        public override void Accept()
        {
            Console.WriteLine("Enter Radius of Sphere:");
            Radius = double.Parse(Console.ReadLine());
        }

        //override method to calculate volume
        public override double Volume()
        {
            return (4.0 / 3.0) * Math.PI * Radius*Radius*Radius; 
        }

    }
}
