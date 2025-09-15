using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppShapeOverLoading.Model
{
    public class Shape
    {
        //cube
        public double Volume(double side)
        {
            return side * side * side; 
        }

        //cylinder

        public double Volume(double radius, double height)
        {
            return Math.PI * radius * radius * height;
        }

        //cone

        public double Volume(double radius, double height, bool isCone)
        {
            return (1.0 / 3.0) * Math.PI * radius * radius * height;

        }

        //sphere
        public double Volume(double radius,bool isSphere)
        {
            return (4.0 / 3.0) * Math.PI * radius * radius * radius;
        }

        

    }
}
