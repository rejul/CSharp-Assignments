using MyAnimals.Service;

namespace Myanimals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyAnimals_ dog = new MyAnimals_();

            // Set temperature using property
            dog.BodyTemp = 101;

            // Call GetBodyTemp (internally calls property)
            Console.WriteLine($"Body temperature is: {dog.GetBodyTemp()}");
        }
    }
}
