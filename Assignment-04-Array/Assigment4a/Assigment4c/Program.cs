namespace Assigment4c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Program to separate odd and even integers into separate arrays

            Console.Write("Enter the size of the array: ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[size];

            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Count evens and odds first
            int evenCount = 0, oddCount = 0;
            for (int i = 0; i < size; i++)
            {
                if (arr[i] % 2 == 0)
                    evenCount++;
                else
                    oddCount++;
            }

            // Create arrays of exact size
            int[] evenArr = new int[evenCount];
            int[] oddArr = new int[oddCount];

            // Fill the arrays
            int eIndex = 0, oIndex = 0;
            for (int i = 0; i < size; i++)
            {
                if (arr[i] % 2 == 0)
                    evenArr[eIndex++] = arr[i];
                else
                    oddArr[oIndex++] = arr[i];
            }

            // Display results
            Console.WriteLine("\nEven elements:");
            foreach (int num in evenArr)
                Console.Write(num + " ");

            Console.WriteLine("\nOdd elements:");
            foreach (int num in oddArr)
                Console.Write(num + " ");
        }
    }
    
}
