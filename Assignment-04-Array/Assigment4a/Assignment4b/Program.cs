namespace Assignment4b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program in C# to find maximum and minimum 
            // element in an array
            Console.Write("Enter the size of the array: ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[size];

            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Initialize max and min with first element
            int max = arr[0];
            int min = arr[0];

            // Traverse the array to find max and min
            for (int i = 1; i < size; i++)
            {
                if (arr[i] > max)
                    max = arr[i];

                if (arr[i] < min)
                    min = arr[i];
            }

            Console.WriteLine("\nMaximum element: " + max);
            Console.WriteLine("Minimum element: " + min);
        }
    }
    }
}
