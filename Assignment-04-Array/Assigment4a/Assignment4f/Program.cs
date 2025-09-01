namespace Assignment4f
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Program to delete an element at desired position from an array

            Console.Write("Enter the size of the array: ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[size];

            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Enter the position to delete (1 to {0}): ", size);
            int pos = Convert.ToInt32(Console.ReadLine());

            if (pos < 1 || pos > size)
            {
                Console.WriteLine("Invalid position!");
            }
            else
            {
                // Shift elements to left from pos
                for (int i = pos - 1; i < size - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }

                size--; // reduce logical size

                Console.WriteLine("\nArray after deletion:");
                for (int i = 0; i < size; i++)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }
    }
    
}
