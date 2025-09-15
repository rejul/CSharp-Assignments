using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCollectionE.Model
{

    public class Employee
    {
        public string Name { get; set; }
        public string WorkPosition { get; set; }
        public int Experience { get; set; } // years

        public Employee(string name, string workPosition, int experience)
        {
            Name = name;
            WorkPosition = workPosition;
            Experience = experience;
        }

        public override string ToString()
        {
            return $"{Name} - {WorkPosition} ({Experience} years experience)";
        }
    }

}