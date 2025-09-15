using System;

class Program3
{
    static void Main()
    { 
        //<summary>
    
        //Write a C# Sharp program to display certain values of 
        // the function x = y2 + 2y + 1 (using integer numbers for y , 
        // ranging from -5 to +5). 

        Console.WriteLine("x = y^2 + 2y + 1");
        for (int y = -5; y <= 5; y++)
        {
            int x = (y * y) + (2 * y) + 1;

            Console.WriteLine($"{y}\t {x}");
        }
    }
}
