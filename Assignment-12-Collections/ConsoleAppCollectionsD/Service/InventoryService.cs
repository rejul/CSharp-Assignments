using ConsoleAppCollectionsD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCollectionsD.Service
{
    public class InventoryService
    {
        private readonly List<Part> parts = new List<Part>();

        public void AddPart()
        {
            Console.Write("Enter Part Code: ");
            string code = Console.ReadLine();

            Console.Write("Enter Part Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Category: ");
            string category = Console.ReadLine();

            Console.Write("Enter Purchase Price: ");
            decimal purchasePrice = decimal.Parse(Console.ReadLine());

            Console.Write("Enter Sale Price: ");
            decimal salePrice = decimal.Parse(Console.ReadLine());

            // Company info
            Console.Write("Enter Manufacturer Name: ");
            string compName = Console.ReadLine();
            Console.Write("Enter Country: ");
            string country = Console.ReadLine();
            Console.Write("Enter Address: ");
            string address = Console.ReadLine();
            Console.Write("Enter Phone: ");
            string phone = Console.ReadLine();
            Console.Write("Enter Fax: ");
            string fax = Console.ReadLine();

            Company manufacturer = new Company(compName, country, address, phone, fax);

            Parts newPart = new Parts(code, name, category, purchasePrice, salePrice, manufacturer);

            // Add compatible cars
            Console.Write("Enter number of compatible cars: ");
            int numCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numCars; i++)
            {
                Console.Write($"Enter Brand for car {i + 1}: ");
                string brand = Console.ReadLine();

                Console.Write("Enter Model: ");
                string model = Console.ReadLine();

                Console.Write("Enter Year: ");
                int year = int.Parse(Console.ReadLine());

                CarModel car = new CarModel(brand, model, year);
                newPart.AddCompatibleCar(car);
            }

            parts.Add(newPart);
            Console.WriteLine("\n Part added successfully!\n");
        }

        public void DisplayParts()
        {
            Console.WriteLine("\n=== Auto Parts Store Inventory ===\n");
            foreach (var part in parts)
            {
                part.DisplayInfo();
            }
        }
    }
}
