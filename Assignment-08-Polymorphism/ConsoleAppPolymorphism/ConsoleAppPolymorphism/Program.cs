using ConsoleAppPolymorphism.Model;

namespace ConsoleAppPolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Null Object ????
            GeometricFigure figure = null;

            //Get input fromm the user
            Console.WriteLine("Choose a shape (\n1. Rectangle\n2. Circle\n3. Square)");
            int choice = Convert.ToInt32(Console.ReadLine());

            //Create respective object and invoke methods
            switch (choice)
            {
                //Rectangle
                case 1:
                    figure = new Rectangle();
                    break;
                //Circle
                case 2:
                    figure = new Circle();
                    break;

                //Square
                case 3:
                    figure = new Square();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    return;


            }

            //polymorphic behavior
            figure.Accept(); 
            figure.Display(); 
            Console.WriteLine($"Area = {figure.Area():F2}"); 

            Console.WriteLine("Do you want to continue? (Y/N)");
            string continueChoice = Console.ReadLine();
            if (continueChoice == "Y")
            {
                Main(args);
            }
            else
            {
                Console.WriteLine("Exiting the program.");
            }



                Console.ReadKey();
        }
    }
}
