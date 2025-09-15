using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCollectionE.Model
{
    //Abstract Base Class
    public abstract class Estate
    {
        public double Area { get; set; }
        public double PricePerSquareMeter { get; set; }
        public string Location { get; set; }

        public Estate(double area, double pricePerSquareMeter, string location)
        {
            Area = area;
            PricePerSquareMeter = pricePerSquareMeter;
            Location = location;
        }

        public virtual double CalculateTotalPrice()
        {
            return Area * PricePerSquareMeter;
        }

        public override string ToString()
        {
            return $"{GetType().Name} in {Location}, {Area} sqm, " +
                   $"Price/sqm: {PricePerSquareMeter}, Total: {CalculateTotalPrice()}";
        }
    }
}
