using System.Collections;

namespace ConsoleAppCollectionB
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create a Hashtable
            Hashtable phoneIndex = new Hashtable();

            Console.Write("Enter the number of contacts: ");
            int n = int.Parse(Console.ReadLine());

            // Take user input for contacts
            for (int i = 0; i < n; i++)
            {
                Console.Write($"\nEnter name for contact {i + 1}: ");
                string name = Console.ReadLine();

                Console.Write($"Enter phone number for {name}: ");
                string phone = Console.ReadLine();

                if (!phoneIndex.ContainsKey(name)) //check for duplicate names
                {
                    phoneIndex.Add(name, phone);
                }
                else
                {
                    Console.WriteLine(" This name already exists. Skipping.");
                }
            }

            // Display phone index
            Console.WriteLine("\n=== Phone Index (Hashtable) ===");
            foreach (DictionaryEntry entry in phoneIndex)
            {
                Console.WriteLine($"{entry.Key} : {entry.Value}");
            }

            // Search functionality
            Console.Write("\nEnter a name to search: ");
            string searchName = Console.ReadLine();

            if (phoneIndex.ContainsKey(searchName))
            {
                Console.WriteLine($"Phone number of {searchName}: {phoneIndex[searchName]}");
            }
            else
            {
                Console.WriteLine("Contact not found.");
            }
        }
    }
}
