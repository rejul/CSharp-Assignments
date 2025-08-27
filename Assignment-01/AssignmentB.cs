using System;

class Program
{
    //<summary>
        // Write a C# Sharp program that takes a number and a 
        // width also a number, as input and then displays a 
        // triangle of that width, using that number 
    //<summary>
    
    static void Main()
    {
        //Input
        Console.Write("Enter the number to use: ");
        int num = Convert.ToInt32(Console.ReadLine());


        Console.Write("Enter the width of the triangle: ");
        int width = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= width; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(num);
            }
            Console.WriteLine(); 
        }
    }
}