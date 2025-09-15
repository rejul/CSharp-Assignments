using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPolyMorphismOverride.Model
{
    public class Sphere: Shape
    {
        public Sphere() { }
        public override void Accept()
        {
            Console.WriteLine("Enter the Radius of the Sphere:");
            Radius = Convert.ToDouble(Console.ReadLine());
        }

        public override double Volume()
        {
            VolumeResult = (4.0 / 3.0) * Math.PI * Math.Pow(Radius, 3);
            return VolumeResult; // Return the calculated volume
        }
        public override void Display()
        {
            Console.WriteLine($"Sphere with Radius: {Radius}");
        }
    }
}
