using System.ComponentModel;

namespace Assignment3B
{
    internal class Program

    {

        //<summary>
        //Write a program in C# to display the pattern like a 
        //diamond.
        //</summary>
        static void Main(string[] args)
        {
            int n = 5 ;

            // Top half
            for (int i = 1; i <= n; i++)
            {

                PrintRow(n, i);
            }

            // Bottom half
            for (int i = n - 1; i >= 1; i--)
            {
                PrintRow(n, i);
            }
        }

        static void PrintRow(int n, int i)
        {
            for (int j = 1; j <= n-i; j++)
            {
                Console.Write(" ");
            }

            for (int k = 1; k <= 2*i-1; k++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

    

    }
    
}
