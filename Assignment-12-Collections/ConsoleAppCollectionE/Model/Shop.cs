using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCollectionE.Model
{
    public class Shop : Estate
    {
        public bool IsInMall { get; set; }

        public Shop(double area, double pricePerSqm, string location, bool isInMall)
            : base(area, pricePerSqm, location)
        {
            IsInMall = isInMall;
        }

        public override string ToString()
        {
            return base.ToString() + $", Located in Mall: {IsInMall}";
        }
    }
}
