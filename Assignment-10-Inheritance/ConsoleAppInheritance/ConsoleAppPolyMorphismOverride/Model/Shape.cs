using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPolyMorphismOverride.Model
{
    public class Shape
    {
        public double Radius { set; get; }
        public double HeightOrLengthOrSide { set;get; }

        public double VolumeResult { set; get; }

        public int Choice { get; set; }



        public Shape() { }

        public virtual void Accept()
        {
            
        }

        public virtual double Volume()
        {
            VolumeResult = Math.Pow(10, 3); // Default volume for base class
            return VolumeResult;


        }

        public virtual void Display()
        {
            Console.WriteLine($"Radius: {Radius}, Height/Length/Side: {HeightOrLengthOrSide} ");
        }
    }
}
