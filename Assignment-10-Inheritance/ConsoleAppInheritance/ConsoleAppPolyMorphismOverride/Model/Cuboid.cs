using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPolyMorphismOverride.Model
{
    public class Cuboid : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public override void Accept()
        {
            Console.WriteLine("Enter Length of Cuboid:");
            Length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Width of Cuboid:");
            Width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Height of Cuboid:");
            Height = Convert.ToDouble(Console.ReadLine());
        }

        public override double Volume()
        {
            VolumeResult = Length * Width * Height;
            return VolumeResult;
        }

        public override void Display()
        {
            Console.WriteLine($"Cuboid with L={Length}, W={Width}, H={Height}");
        }
    }

}
