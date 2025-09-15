using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCollectionC.Model
{    // Vehicle class

    public class Vehicle
    {
        public string LicenseNumber { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }

        public Vehicle(string licenseNumber, string brand, string model)
        {
            LicenseNumber = licenseNumber;
            Brand = brand;
            Model = model;
        }

        public override string ToString()
        {
            return $"License: {LicenseNumber}, Brand: {Brand}, Model: {Model}";
        }
    }
}
