namespace PatternA
{
    internal class Program
    {
        static void Main(string[] args)
        { //Write a C# program to display alphabet pattern like A 
         // with an asterisk.   
         // Reversed string is: Display the pattern like 
         // 'A' with an asterisk:                                                                          
         //                                                                                  
         //   ***                                                                            
         //  *   *                                                                           
         //  *   *                                                                           
         //  *****                                                                           
         //  *   *                                                                           
         //  *   *                                                                           
         //  *   *                                                                           
         //  *   * 
            int height = 7; // Number of rows
            int width = (height / 2) + 2; // Width for middle line

            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col <= width; col++)
                {
                    // Top row of A
                    if ((row == 0 && col > 0 && col < width) ||

                        // Middle horizontal line
                        (row == height / 2 && col > 0 && col < width) ||

                        // Left diagonal
                        (col == 0 && row != 0) ||

                        // Right diagonal
                        (col == width && row != 0))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
