namespace Assignment4j
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program in C# to accept two matrices and check 
            // whether they are equal 
            Console.WriteLine("Enter the size of Matrix");
            int size = Convert.ToInt32(Console.ReadLine());

            int[][] matrixA = new int[size][];
            int[][] matrixB = new int[size][];

            //intialize the matrices
            for (int i = 0; i < size; i++)
            {
                matrixA[i] = new int[size];
                matrixB[i] = new int[size];
            }
            // Input values for the first matrix
            Console.WriteLine("Enter values for the first matrix:");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrixA[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            // Input values for the second matrix
            Console.WriteLine("Enter values for the second matrix:");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrixB[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            // Check if the matrices are equal
            bool areEqual = true;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (matrixA[i][j] != matrixB[i][j])
                    {
                        areEqual = false;
                        break;
                    }
                }
                if (!areEqual)
                    break;
            }
            Console.WriteLine("The matrices are " + (areEqual ? "equal." : "not equal."));
        }
    }
}
