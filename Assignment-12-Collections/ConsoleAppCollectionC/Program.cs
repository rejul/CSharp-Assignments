using ConsoleAppCollectionC.Model;

namespace ConsoleAppCollectionC
{

    // VehicleRegistration class
    public class VehicleRegistration
    {
        private Dictionary<string, Vehicle> vehicles = new Dictionary<string, Vehicle>();

        // Add Vehicle
        public void RegisterVehicle(Vehicle vehicle)
        {
            if (!vehicles.ContainsKey(vehicle.LicenseNumber))
            {
                vehicles.Add(vehicle.LicenseNumber, vehicle);
                Console.WriteLine($"Vehicle with license {vehicle.LicenseNumber} registered.");
            }
            else
            {
                Console.WriteLine("License number already exists!");
            }
        }

        // Retrieve Vehicle by license number
        public Vehicle GetVehicle(string licenseNumber)
        {
            if (vehicles.ContainsKey(licenseNumber))
            {
                return vehicles[licenseNumber];
            }
            else
            {
                Console.WriteLine("Vehicle not found!");
                return null;
            }
        }
    }

    // Main Program
    class Program
    {
        static void Main(string[] args)
        {
            VehicleRegistration registration = new VehicleRegistration();

            Console.WriteLine("How many vehicles do you want to register?");
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"\nEnter details for Vehicle {i + 1}:");

                Console.Write("License Number: ");
                string license = Console.ReadLine();

                Console.Write("Brand: ");
                string brand = Console.ReadLine();

                Console.Write("Model: ");
                string model = Console.ReadLine();

                Vehicle v = new Vehicle(license, brand, model);
                registration.RegisterVehicle(v);
            }

            Console.WriteLine("\nEnter license number to search for a vehicle: ");
            string searchLicense = Console.ReadLine();

            Vehicle foundVehicle = registration.GetVehicle(searchLicense);
            if (foundVehicle != null)
            {
                Console.WriteLine("Vehicle found: " + foundVehicle);
            }
        }
    }
}
