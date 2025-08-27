using System;

namespace App3
{
    class Program
    //<summary>
    // Write a C# Sharp program that takes distance and time 
    // as input and displays the speed in kilometers per hour 
    // and miles per hour. 
    //</summary>
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Input Distance (Km):");
            double distanceInKm = double.Parse(Console.ReadLine());

            Console.WriteLine("Input Time (Hr):");
            double time = double.Parse(Console.ReadLine());

            double speed = distanceInKm / time;
            double speedInMiles = speed / 1.60934;

            Console.WriteLine($"Speed in Km/h: {speed}");
            Console.WriteLine($"Speed in Miles/h: {speedInMiles:F2}");
        }
    }
}

