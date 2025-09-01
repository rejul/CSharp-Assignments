namespace Assignment4g
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Program to find the second smallest element in an array

            Console.Write("Enter the size of the array: ");
            int size = Convert.ToInt32(Console.ReadLine());

            if (size < 2)
            {
                Console.WriteLine("Array must have at least 2 elements!");
                return;
            }

            int[] arr = new int[size];

            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Initialize smallest and second smallest
            int smallest = int.MaxValue;//placeholder for the smallest element
            int secondSmallest = int.MaxValue;

            for (int i = 0; i < size; i++)
            {
                if (arr[i] < smallest)
                {
                    secondSmallest = smallest;
                    smallest = arr[i];
                }
                else if (arr[i] < secondSmallest && arr[i] != smallest)
                {
                    secondSmallest = arr[i];
                }
            }

            if (secondSmallest == int.MaxValue)
            {
                Console.WriteLine("No second smallest element (all elements are equal).");
            }
            else
            {
                Console.WriteLine("\nSecond smallest element: " + secondSmallest);
            }
        }
    }
    
}
