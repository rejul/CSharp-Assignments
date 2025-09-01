namespace PatternbyAlphabet
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
            Console.WriteLine("Pattern by Alphabet");
            char alphabet = 'A';
            for (int i = 1; i <= 4; i++)
            {
                // Print increasing part
                for (int j = 0; j < i; j++)
                {
                    Console.Write(alphabet + j + " ");
                }
                // Print decreasing part
                for (int j = i - 2; j >= 0; j--)
                {
                    Console.Write(alphabet + j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
