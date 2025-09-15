using System;
using ConsoleAppCollectionE.Model;
using ConsoleAppCollectionE.Validation;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Real Estate Management System ===");

        // Company details
        string companyName = InputHelper.GetString("Enter company name: ");
        string owner = InputHelper.GetString("Enter owner name: ");
        string taxId = InputHelper.GetString("Enter tax ID: ");

        Company company = new Company(companyName, owner, taxId);

        // Add Employees
        int empCount = InputHelper.GetInt("How many employees to add? ", 1);
        for (int i = 0; i < empCount; i++)
        {
            Console.WriteLine($"\n--- Employee {i + 1} ---");
            string empName = InputHelper.GetString("Enter employee name: ");
            string position = InputHelper.GetString("Enter work position: ");
            int exp = InputHelper.GetInt("Enter experience (years): ", 0);
            company.AddEmployee(new Employee(empName, position, exp));
        }

        // Add Estates
        int estateCount = InputHelper.GetInt("\nHow many estates to add? ", 1);
        for (int i = 0; i < estateCount; i++)
        {
            Console.WriteLine($"\n--- Estate {i + 1} ---");
            Console.WriteLine("1. Apartment\n2. House\n3. Shop\n4. Undeveloped Area");
            int choice = InputHelper.GetInt("Choose estate type: ", 1, 4);

            double area = InputHelper.GetDouble("Enter area (sqm): ", 1);
            double price = InputHelper.GetDouble("Enter price per sqm: ", 1);
            string location = InputHelper.GetString("Enter location: ");

            switch (choice)
            {
                case 1:
                    int floor = InputHelper.GetInt("Enter floor: ");
                    bool hasElevator = InputHelper.GetBool("Has elevator?");
                    bool furnished = InputHelper.GetBool("Is furnished?");
                    company.AddEstate(new Apartment(area, price, location, floor, hasElevator, furnished));
                    break;

                case 2:
                    double yard = InputHelper.GetDouble("Enter yard area (sqm): ", 0);
                    int floors = InputHelper.GetInt("Enter number of floors: ", 1);
                    bool houseFurnished = InputHelper.GetBool("Is furnished?");
                    company.AddEstate(new House(area, price, location, yard, floors, houseFurnished));
                    break;

                case 3:
                    bool inMall = InputHelper.GetBool("Is it inside a mall?");
                    company.AddEstate(new Shop(area, price, location, inMall));
                    break;

                case 4:
                    bool urbanized = InputHelper.GetBool("Is it urbanized?");
                    company.AddEstate(new UndevelopedArea(area, price, location, urbanized));
                    break;
            }
        }

        // Display summary
        Console.WriteLine("\n=== Company Overview ===");
        company.ShowCompanyInfo();

        Console.WriteLine("\nProgram finished. Press Enter to exit.");
        Console.ReadLine();
    }

}
