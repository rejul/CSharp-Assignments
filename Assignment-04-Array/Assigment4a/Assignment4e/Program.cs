namespace Assignment4e
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Program to insert new value into a sorted array (with one free slot at the end)

            Console.Write("Enter the size of the array (including extra space): ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[size];

            Console.WriteLine("Enter " + (size - 1) + " elements in sorted order:");
            for (int i = 0; i < size - 1; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Enter the new value to insert: ");
            int newValue = Convert.ToInt32(Console.ReadLine());

            int n = size - 1; // actual number of filled elements
            int pos = n;      // default insert at end

            for (int i = 0; i < n; i++)
            {
                if (newValue < arr[i])
                {
                    pos = i;
                    break;
                }
            }

            // Shift elements to right to make space
            for (int i = n; i > pos; i--)
            {
                arr[i] = arr[i - 1];
            }

            arr[pos] = newValue;

            Console.WriteLine("\nArray after insertion:");
            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
    
}
