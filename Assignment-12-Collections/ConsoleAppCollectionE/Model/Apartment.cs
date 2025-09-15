using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCollectionE.Model
{
    public class Apartment : Estate
    {
        public int Floor { get; set; }
        public bool HasElevator { get; set; }
        public bool IsFurnished { get; set; }

        public Apartment(double area, double pricePerSqm, string location,
                         int floor, bool hasElevator, bool isFurnished)
            : base(area, pricePerSqm, location)
        {
            Floor = floor;
            HasElevator = hasElevator;
            IsFurnished = isFurnished;
        }

        public override string ToString()
        {
            return base.ToString() +
                   $", Floor: {Floor}, Elevator: {HasElevator}, Furnished: {IsFurnished}";
        }
    }
}
