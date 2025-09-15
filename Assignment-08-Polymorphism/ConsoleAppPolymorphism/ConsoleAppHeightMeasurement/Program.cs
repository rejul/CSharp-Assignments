using ConsoleAppHeightMeasurement.Model;

namespace ConsoleAppHeightMeasurement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Height h = new Height(5, 11);
            h.Display(); //initial height

            
            for (int i = 0; i < 3; i++)
            {
                h = +h; // increment
                h.Display(); 
            }
        }
    }
}
