using System;

namespace DelegateArrayOperation
{
    class Program
    {
        // Step 1: Declare a delegate
        public delegate int[] ArrayOperation(int[] arr);

        // Step 2: Define Sort method
        public static int[] SortArray(int[] arr)
        {
            Array.Sort(arr);
            return arr;
        }

        // Step 3: Define Reverse method
        public static int[] ReverseArray(int[] arr)
        {
            Array.Reverse(arr);
            return arr;
        }

        static void Main(string[] args)
        {
            // Input array
            int[] numbers ;

            numbers = new int[10];

            // Input 10 integers from user
            Console.WriteLine("Enter 10 integers:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Number {i + 1}: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Original Array: " + string.Join(", ", numbers));

            // Step 4: Ask user for choice
            Console.WriteLine("\nEnter your choice:");
            Console.WriteLine("1. Sort");
            Console.WriteLine("2. Reverse");
            Console.Write("Choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            // Step 5: Declare delegate
            ArrayOperation operation;

            // Step 6: Assign method based on user choice
            if (choice == 1)
            {
                operation = new ArrayOperation(SortArray);
            }
            else if (choice == 2)
            {
                operation = new ArrayOperation(ReverseArray);
            }
            else
            {
                Console.WriteLine("Invalid choice. Exiting...");
                return;
            }

            // Step 7: Invoke delegate
            int[] result = operation(numbers);

            // Step 8: Display result
            Console.WriteLine("\nResulting Array: " + string.Join(", ", result));
        }
    }
}