using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPolymorphism.Model
{
    public class Circle : GeometricFigure
    {
        //fields
        public double Radius { get; set; }

        //default constructor

        //Method to accept radius
        public override void Accept()
        {
            NoOfSides = 0; //Circle has no sides
            Console.WriteLine("Enter Radius:");
            Radius = double.Parse(Console.ReadLine());
        }

        //override Method to display
        public override void Display()
        {
            Console.WriteLine($"Circle - Sides: {NoOfSides}, Radius: {Radius}");
        }

        //override Method to calculate area
        public override double Area()
        {
            return Math.PI * Radius * Radius; 
        }

    }

}
