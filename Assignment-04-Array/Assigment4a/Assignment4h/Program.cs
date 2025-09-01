namespace Assignment4h
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program in C# for multiplication of two square 
            // Matrices 
            // 2D Array (3x3 fixed grid)
            int[,] rectArray = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            // Jagged Array (rows of different lengths)
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 1, 2 };
            jaggedArray[1] = new int[] { 3, 4, 5, 6 };
            jaggedArray[2] = new int[] { 7, 8, 9 };

            // Print 2D array
            Console.WriteLine("2D Array:");
            for (int i = 0; i < rectArray.GetLength(0); i++)
            {
                for (int j = 0; j < rectArray.GetLength(1); j++)
                    Console.Write(rectArray[i, j] + " ");
                Console.WriteLine();
            }

            // Print Jagged array
            Console.WriteLine("\nJagged Array:");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                    Console.Write(jaggedArray[i][j] + " ");
                Console.WriteLine();
            }
        }
    }
}
