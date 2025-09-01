using System;

namespace Assignment4k
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a C# program to sort a list of elements using 
            // Bubble sort.  

            Console.WriteLine("Enter the size of array");
            int size = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the array");
            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Console.WriteLine($"Array before Sorting {arr}");
            for (int i = 0; i < size; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (arr[i] > arr[j]) //ascending
                    {
                        // swap
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }

            }
            Console.WriteLine($"Sorted Array is");

            foreach (var num in arr)
            {
                Console.Write($"{num}  ");
            }

        }
    }
}
