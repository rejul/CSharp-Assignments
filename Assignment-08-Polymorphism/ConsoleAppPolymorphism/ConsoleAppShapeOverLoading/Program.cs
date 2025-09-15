using ConsoleAppShapeOverLoading.Model;

namespace ConsoleAppShapeOverLoading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Shape();

            while (true)
            {
                Console.WriteLine("Choose a shape to calculate volume:");
                Console.WriteLine("1. Cube");
                Console.WriteLine("2. Sphere");
                Console.WriteLine("3. Cylinder");
                Console.WriteLine("4.Cone");
                Console.WriteLine("Enter your choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());

                double Volume = 0;

                //method  for shapes
                if (choice == 1)
                {
                    Console.WriteLine("Enter the side length :");
                    double side = Convert.ToDouble(Console.ReadLine());
                    Volume = shape.Volume(side);

                }
                else if (choice == 2)
                {
                    Console.WriteLine("Enter the radius :");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    Volume = shape.Volume(radius);
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Enter the radius :");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the height :");
                    double height = Convert.ToDouble(Console.ReadLine());
                    Volume = shape.Volume(radius, height);

                }
                else if (choice == 4)
                {
                    Console.WriteLine("Enter the radius :");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the height :");
                    double height = Convert.ToDouble(Console.ReadLine());
                    Volume = shape.Volume(radius, height);
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
                }

                //show the result
                Console.WriteLine($"The volume of the selected shape is: {Volume:F2}");

            }
        }
    }
}

