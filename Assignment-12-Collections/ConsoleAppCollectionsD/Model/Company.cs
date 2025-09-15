using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCollectionsD.Model
{
    public class Company
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }

        public Company(string name, string country, string address, string phone, string fax)
        {
            Name = name;
            Country = country;
            Address = address;
            Phone = phone;
            Fax = fax;
        }

        public override string ToString()
        {
            return $"{Name}, {Country}, Phone: {Phone}, Fax: {Fax}";
        }
    }
}
