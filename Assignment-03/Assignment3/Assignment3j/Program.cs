namespace Assignment3jPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a C# Program to display the following pattern 
            // using the alphabet.  
            // A 
            // A B A  
            // A B C B A 
            // A B C D C B A  

            Console.Write("Enter number of rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= rows; i++)
            {
                // Left side (A, B, C ...)
                for (int j = 0; j < i; j++)
                {
                    Console.Write((char)('A' + j) + " ");
                }

                // Right side (reverse without last char)
                for (int j = i - 2; j >= 0; j--)
                {
                    Console.Write((char)('A' + j) + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
