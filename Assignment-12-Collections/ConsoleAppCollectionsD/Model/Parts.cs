using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCollectionsD.Model
{
    public class Parts
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }
        public List<CarModel> CompatibleCars { get; set; }
        public Company Manufacturer { get; set; }

        public Parts(string code, string name, string category,
            decimal purchasePrice, decimal salePrice,
            Company manufacturer)
        {
            Code = code;
            Name = name;
            Category = category;
            PurchasePrice = purchasePrice;
            SalePrice = salePrice;
            Manufacturer = manufacturer;
            CompatibleCars = new List<CarModel>();
        }

        public void AddCompatibleCar(CarModel car)
        {
            CompatibleCars.Add(car);
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Code: {Code}, Name: {Name}, Category: {Category}");
            Console.WriteLine($"Purchase Price: {PurchasePrice:C}, Sale Price: {SalePrice:C}");
            Console.WriteLine($"Manufacturer: {Manufacturer}");
            Console.WriteLine("Compatible Cars:");
            foreach (var car in CompatibleCars)
            {
                Console.WriteLine($"   - {car}");
            }
            Console.WriteLine("--------------------------------------------");
        }
    }
}
