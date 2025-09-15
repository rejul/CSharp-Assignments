using ConsoleAppShape.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppShapeVolume.Model
{
    public class Cone : Shape
    {
        //fields
        public double Radius { get; set; }
        public double Height { get; set; }

        //default constructor

        //method to accept radius and height

        public override void Accept()
        {
            Console.WriteLine("Enter Radius of Cone:");
            Radius = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Height of Cone:");
            Height = double.Parse(Console.ReadLine());
        }

        //method to calculate volume of cone
        public override double Volume()
        {
            return (1.0 / 3.0) * Math.PI * Radius * Radius * Height; 
        }
    }
}
