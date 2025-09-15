using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHeightMeasurement.Model
{
    public class Height : Measurement
    {
        public int Feet { get; set; }
        public int Inches { get; set; }

        public Height(int feet, int inches)
        {
            Feet = feet;
            Inches = inches;
        }

        // Overload 
        public static Height operator +(Height h)
        {
            h.Inches += 1;
            if (h.Inches >= 12)
            {
                h.Inches = 0;
                h.Feet += 1;
            }
            return h;
        }

        // Override Display using polymorphism
        public override void Display()
        {
            Console.WriteLine($"Height: {Feet} feet {Inches} inches");
        }
    }
}
