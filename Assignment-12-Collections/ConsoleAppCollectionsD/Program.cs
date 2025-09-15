using ConsoleAppCollectionsD.Service;

namespace ConsoleAppCollectionsD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InventoryService inventory = new InventoryService();

            Console.Write("Enter number of parts to add: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\n--- Adding Part {i + 1} ---");
                inventory.AddPart();
            }

            inventory.DisplayParts();
        }
    }
}
