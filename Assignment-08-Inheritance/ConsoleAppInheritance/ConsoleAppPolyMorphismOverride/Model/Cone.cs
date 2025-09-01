using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPolyMorphismOverride.Model
{
    public class Cone : Shape
    {
     

        public override void Accept()
        {
            Console.WriteLine("Enter Radius of Cone:");
            Radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Height of Cone:");
            HeightOrLengthOrSide = Convert.ToDouble(Console.ReadLine());
        }

        public override double Volume()
        {
            VolumeResult = (1.0 / 3.0) * Math.PI * Math.Pow(Radius, 2) * HeightOrLengthOrSide;
            return VolumeResult;
        }

        public override void Display()
        {
            Console.WriteLine($"Cone with Radius: {Radius}, Height: {HeightOrLengthOrSide}");
        }
    }
}
