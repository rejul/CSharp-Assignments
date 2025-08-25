using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPolyMorphism.Model
{
    public class GeometricFigure
    {
        public int NoOfSides { get; set; }

        //default constructor
        public GeometricFigure() { }
        //parametrized constructor
        public GeometricFigure(int noOfSides)
        {
            NoOfSides = noOfSides;
        }

        //method to Accept sides

        public virtual void Accept() // This method will be overridden in derived classes -virtual keyword
        {
            Console.WriteLine("Enter the Number of side: ");
            NoOfSides = Convert.ToInt32(Console.ReadLine());
        }

        //Area
        public virtual double Area()
        {
            return 0; //default area for base class
        }

        //method to display sides
        public virtual void Display()
        {
            Console.WriteLine($"Number of sides: {NoOfSides}");
        }
    }
}
