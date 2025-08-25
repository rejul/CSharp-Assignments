using System.ComponentModel.DataAnnotations;
using ConsolePolyMorphism.Model;

namespace ConsolePolyMorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {//Create a class shape, Which is capable of representing different geometric 
         // figures like cube, sphere, cylinder, cone etc. Write a method to find out the 
         // volume of each shape, it should take the argument of same type (radius both 
         // radius and height). Reads the shape and its radius and/or height as it is and 
         // displays the result. If the volume method is invoked without any arguments then 
         // the default size should be taken as 10 assuming the shape to be a cube. 


            Console.WriteLine("Welcome");

            Console.WriteLine("Enter the your Choice  \n1.Cube\n2.Sphere\n3.Cylinder\n4.Cone\n5.Cuboid:");
            int shapeType = Convert.ToInt32(Console.ReadLine());
            Shape shape = new Shape(); // Create an instance of the Shape class
            double volume = 0;
            switch (shapeType)
            {
                case 1: // Cube
                    Console.WriteLine("Enter the side length of the cube:");
                    string input = Console.ReadLine();
                    int length;
                    // If length is not provided, use default size for cube
                    if (int.TryParse(input,out length))
                        volume = shape.Volume(length);
                    else 
                        volume = shape.Volume(); // Default size for cube
                    Console.WriteLine($"Volume of Cube: {volume}");
                    break;
                case 2: // Sphere
                    Console.WriteLine("Enter the radius of the sphere:");
                    double radius = Convert.ToInt32(Console.ReadLine());
                    volume = shape.Volume(radius); 
                    Console.WriteLine($"Volume of Sphere: {volume}");
                    break;
                case 3: // Cylinder
                    Console.WriteLine("Enter the radius of the cylinder:");
                    int cylinderRadius = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the height of the cylinder:");
                    int cylinderHeight = Convert.ToInt32(Console.ReadLine());
                    volume = shape.Volume(cylinderRadius, cylinderHeight, false);
                    Console.WriteLine($"Volume of Cylinder: {volume}");
                    break;
                case 4: // Cone
                    Console.WriteLine("Enter the radius of the cone:");
                    int coneRadius = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the height of the cone:");
                    int coneHeight = Convert.ToInt32(Console.ReadLine());
                    volume = shape.Volume(coneRadius, coneHeight, true);
                    Console.WriteLine($"Volume of Cone: {volume}");
                    break;
                case 5: // Cuboid
                    Console.WriteLine("Enter the length of the cuboid:");
                    int cuboidLength = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the width of the cuboid:");
                    int cuboidWidth = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the height of the cuboid:");
                    int cuboidHeight = Convert.ToInt32(Console.ReadLine());
                    volume = shape.Volume(cuboidLength, cuboidWidth, cuboidHeight);
                    Console.WriteLine($"Volume of Cuboid: {volume}");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid shape type.");
                    break;

            }

        }
    }
}
