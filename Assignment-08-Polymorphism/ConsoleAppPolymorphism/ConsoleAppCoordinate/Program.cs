using System.Drawing;

namespace ConsoleAppCoordinate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Using Rectangle with properties
            Rectangle rect = new Rectangle(5, 10);
            rect.Display();

            // Change YCoordinate using method
            rect.SetYCoordinate(7);
            rect.Display();

           

            // Demonstrating polymorphism
            Shape shape1 = rect;
            Console.ReadKey();
        }
    }
}
