using ConsoleAppShape.Model;
using ConsoleAppShapeVolume.Model;

namespace ConsoleAppShape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Null Object ????
            Shape fig = null;

            //Get input from the user
            Console.WriteLine("Choose a shape (\n1. Cube \n2. Sphere \n3. Cylinder \n4. Cone)");
            int choice = Convert.ToInt32(Console.ReadLine());

            //Create respective object and invoke methods
            switch (choice)
            {
                
                case 1:
                    fig = new Cube();
                    break;
                
                case 2:
                    fig = new Sphere();
                    break;

                
                case 3:
                    fig = new Cylinder();
                    break;

                case 4: 
                    fig  = new Cone();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    return;


            }

            //polymorphic behavior
            fig.Accept();
            Console.WriteLine($"Area = {fig.Volume():F2}");




            Console.ReadKey();
        }
    }

}
