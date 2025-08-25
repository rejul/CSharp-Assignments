using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPolyMorphismOverride.Model
{
    public class Cube : Shape
    {
        

        public override void Accept()
        {
            Console.WriteLine("Enter the Side length of the Cube:");
            HeightOrLengthOrSide = Convert.ToDouble(Console.ReadLine());
        }

        public override double Volume()
        {
            VolumeResult = Math.Pow(HeightOrLengthOrSide, 3);
            return VolumeResult;
        }

        public override void Display()
        {
            Console.WriteLine($"Cube with Side: {HeightOrLengthOrSide}");
        }
    }
}
