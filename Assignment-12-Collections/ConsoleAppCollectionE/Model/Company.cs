using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCollectionE.Model
{
    public class Company
    {
        public string Name { get; set; }
        public string Owner { get; set; }
        public string TaxID { get; set; }

        public List<Employee> Employees { get; set; }
        public List<Estate> Estates { get; set; }

        public Company(string name, string owner, string taxId)
        {
            Name = name;
            Owner = owner;
            TaxID = taxId;
            Employees = new List<Employee>();
            Estates = new List<Estate>();
        }

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }

        public void AddEstate(Estate estate)
        {
            Estates.Add(estate);
        }

        public void ShowCompanyInfo()
        {
            Console.WriteLine($"Company: {Name}, Owner: {Owner}, TaxID: {TaxID}");
            Console.WriteLine("\nEmployees:");
            foreach (var e in Employees)
                Console.WriteLine(" - " + e);

            Console.WriteLine("\nEstates for Sale:");
            foreach (var est in Estates)
                Console.WriteLine(" - " + est);
        }
    }
}

