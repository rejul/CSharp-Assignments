namespace Assigment4a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program in C# to count a total number of 
            // duplicate elements in an array

            Console.Write("Enter the size of the array: ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[size];

            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            bool[] visited = new bool[size]; // To keep track of already counted elements
            int duplicateCount = 0;

            for (int i = 0; i < size; i++)
            {
                if (visited[i]) continue; // Skip if already checked

                int count = 1;
                for (int j = i + 1; j < size; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        visited[j] = true; // Mark as visited
                    }
                }

                if (count > 1)
                {
                    duplicateCount++;
                }
            }

            Console.WriteLine("\nTotal number of duplicate elements: " + duplicateCount);
        }
    }
}
