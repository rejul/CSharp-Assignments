using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsolePolyMorphism.Model
{
    public class Shape

    {
        //private string Shape = "";

        public Shape()
        {

        }

        //volume for cube with default size
        public double Volume()
        {
            double side = 10; // Default size for cube
            return Math.Pow(side, 3); // Volume of cube = side^3
        }

        //volume for cube
        public double Volume(int side)
        {
            return Math.Pow(side, 3); // Volume of cube = side^3
        }

        //volume for sphere
        public double Volume(double radius)
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3); // Volume of sphere = (4/3)πr^3

        }
        //volume for cone and cylinder
        public double Volume(int radius, int height, bool isCone)
        {
            if (isCone)
            {
                return (1.0 / 3.0) * Math.PI * Math.Pow(radius, 2) * height; // Volume of cone = (1/3)πr^2h
            }
            else
            {
                return Math.PI * Math.Pow(radius, 2) * height; // Volume of cylinder = πr^2h
            }
        }
        //volume for cuboid
        // This method calculates the volume of a cuboid given its length, width, and height
        public double Volume(int length, int width, int height)
        {
            return length * width * height; // Volume of cuboid = length * width * height
        }

       
    }
}
