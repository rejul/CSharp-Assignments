namespace Assignment4i
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Write a program in C# for multiplication of two square 
            // Matrices 

         

            Console.WriteLine("Enter the size of array ");
            int size = Convert.ToInt32(Console.ReadLine());


            // Define two 3x3 matrices
            int[][] matrixA = new int[size][];
            int[][] matrixB = new int[size][];
            int[][] resultMatrix = new int[size][];



            //intialize the matrices
            for (int i = 0; i < size; i++)
            {
                matrixA[i] = new int[size];
                matrixB[i] = new int[size];
                resultMatrix[i] = new int[size];

            }


            // Input values for the first matrix
            
            for (int i=0; i < size; i++) {
                for (int j = 0; j < size; j++)
                {
                    matrixA[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Input values for the second matrix
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrixB[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Perform matrix multiplication
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    for (int k= 0; k < size; k++)
                    {
                        resultMatrix[i][j] += matrixA[i][k] * matrixB[k][j];
                    }
                }
            }

            // Print the result matrix
            Console.WriteLine("Resultant Matrix after multiplication:");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(resultMatrix[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
