using System.Threading.Channels;

namespace ConsoleAppDelegationDemo
{
    public class Program
    {
        public delegate void RectangleDelegate(double width, double height);

        static void Main(string[] args)
        {
            Program program = new Program();
            Console.WriteLine("___Area and Perimeter Calculator____");
            RectangleDelegate rectangleDelegate = new RectangleDelegate(program.GetArea);
            rectangleDelegate.Invoke(5.5, 6.5);



            //Find Area and Perimeter of Rectangle
            //Get Area
            Console.WriteLine("After MultiCast");
            rectangleDelegate += program.GetPerimeter;
            rectangleDelegate.Invoke(15.6,9.5);

            //remove area
            rectangleDelegate -= program.GetArea;

            Console.WriteLine("After Removing Area");
            rectangleDelegate.Invoke(12.2, 13.5); //Perimeter
        }
        
        public void GetArea(double width, double height)
        {
            double area = width * height;
            Console.WriteLine($"Area of Rectangle is : {area}");
        }

        public void GetPerimeter(double width, double height)
        {
            double perimeter = 2 * (width + height);
            Console.WriteLine($"Perimeter of Rectangle is : {perimeter}");
        }


    }
}