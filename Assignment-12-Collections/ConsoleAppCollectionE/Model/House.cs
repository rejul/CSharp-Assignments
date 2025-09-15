using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCollectionE.Model
{
    public class House : Estate
    {
        public double YardArea { get; set; }
        public int Floors { get; set; }
        public bool IsFurnished { get; set; }

        public House(double area, double pricePerSqm, string location,
                     double yardArea, int floors, bool isFurnished)
            : base(area, pricePerSqm, location)
        {
            YardArea = yardArea;
            Floors = floors;
            IsFurnished = isFurnished;
        }

        public override string ToString()
        {
            return base.ToString() +
                   $", Yard: {YardArea} sqm, Floors: {Floors}, Furnished: {IsFurnished}";
        }
    }

}
