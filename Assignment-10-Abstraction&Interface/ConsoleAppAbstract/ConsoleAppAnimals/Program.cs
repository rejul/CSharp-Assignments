using ConsoleAppAnimals.Model;
namespace ConsoleAppAnimals
{
    public class AnimalImplementation : Animals
    {
        public override void SaySomething()
        {
            Console.WriteLine("Say Something Please");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
           AnimalImplementation animal = new AnimalImplementation();
           animal.SaySomething();
        }
    }
}
