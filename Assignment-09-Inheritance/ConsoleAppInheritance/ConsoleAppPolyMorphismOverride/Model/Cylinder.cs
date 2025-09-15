using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPolyMorphismOverride.Model
{
    public class Cylinder : Shape
    {

        public override void Accept()
        {
            Console.WriteLine("Enter Radius of Cylinder:");
            Radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Height of Cylinder:");
            HeightOrLengthOrSide = Convert.ToDouble(Console.ReadLine());
        }

        public override double Volume()
        {
            VolumeResult = Math.PI * Math.Pow(Radius, 2) * HeightOrLengthOrSide;
            return VolumeResult;
        }

        public override void Display()
        {
            Console.WriteLine($"Cylinder with Radius: {Radius}, Height: {HeightOrLengthOrSide}");
        }
    }

}
