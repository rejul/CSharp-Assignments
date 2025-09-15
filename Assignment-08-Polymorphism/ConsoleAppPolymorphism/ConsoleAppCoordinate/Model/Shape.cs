using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCoordinate.Model
{
    //base class
    public class Shape
    {
        public virtual double GetArea()
        {
            return 0;
        }   

        //method to display data
        public virtual void Display()
        {
            Console.WriteLine("This is a shape.");
        }
    }
}
