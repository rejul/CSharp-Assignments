using ConsoleAppPolyMorphismOverride.Model;
namespace ConsoleAppPolyMorphismOverride
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MENU");
            Console.WriteLine("1.Cube\n2.Cone\n3.Cylinder\n4.Sphere\n5.Cuboid");
            Console.WriteLine("Enter your choice:");
            int choice = Convert.ToInt32(Console.ReadLine());


            switch (choice)
            {
                case 1:
                    Shape cube = new Cube();
                    cube.Accept();
                    double volumeCube = cube.Volume();
                    Console.WriteLine(volumeCube);
                    cube.Display();
                    break;
                case 2:
                    Shape cone = new Cone();
                    cone.Accept();
                    double volumeCone = cone.Volume();
                    Console.WriteLine(volumeCone);
                    cone.Display();
                    break;
                case 3:
                    Shape cylinder = new Cylinder();
                    cylinder.Accept();
                    double volumeCylinder = cylinder.Volume();
                    Console.WriteLine(volumeCylinder);
                    cylinder.Display();
                    break;
                case 4:
                    Shape sphere = new Sphere();
                    sphere.Accept();
                    double volumeSphere = sphere.Volume();
                    Console.WriteLine(volumeSphere);
                    sphere.Display();
                    break;
                case 5:
                    Shape cuboid = new Cuboid();
                    cuboid.Accept();
                    double volumeCuboid = cuboid.Volume();
                    Console.WriteLine(volumeCuboid);
                    cuboid.Display();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option from the menu.");
                    break;

            }
        }
    }
}
