using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPolymorphism.Model
{
    //base class
    public class GeometricFigure
    {

        //Common fields/attributes/properties
        public int NoOfSides { get; set; }

        //default constructor
        public GeometricFigure()
        {
            
        }
        //parameterized constructor

        //Method to accept sides
        public virtual void Accept()
        {
            Console.WriteLine("Enter number of sides:");
            NoOfSides = Convert.ToInt32(Console.ReadLine());
        }

        //Virtual Method to display
        public virtual void Display()
        {
            Console.WriteLine($"Number of sides: { NoOfSides}");
        }

        //Virtual Method to calculate area
        public virtual double Area()
        {
            return 0; //Default (not meaningful here)
        }

    }
}
