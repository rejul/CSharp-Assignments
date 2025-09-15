
using ConsoleAppPolyMorphism.Model;

namespace ConsoleAppPolyMorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a null object of base class
            GeometricFigure figure = null;

            //get details from user
            Console.WriteLine("Choose a shape \n1.Rectangle \n2.Square \n3.Circle" );
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                //Rectangle
                case 1:
                    figure = new Model.Rectangle(); // Create a Rectangle object
                    break;
                case 2:
                    figure = new Model.Square(); // Create a Square object
                    break;
                case 3:
                    figure = new Model.Circle(); // Create a Circle object
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid shape.");
                    return; // Exit the program if the choice is invalid
            }
            //polymorphic behavior
            figure.Accept(); // Call the Accept method to get details
            figure.Display(); // Call the Display method to show details
            Console.WriteLine($"Area={figure.Area():F2}");

        }
    }
}
