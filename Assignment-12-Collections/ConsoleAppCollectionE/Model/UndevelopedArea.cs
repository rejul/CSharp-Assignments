using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCollectionE.Model
{
    public class UndevelopedArea : Estate
    {
        public bool IsUrbanized { get; set; }

        public UndevelopedArea(double area, double pricePerSqm, string location, bool isUrbanized)
            : base(area, pricePerSqm, location)
        {
            IsUrbanized = isUrbanized;
        }

        public override string ToString()
        {
            return base.ToString() + $", Urbanized: {IsUrbanized}";
        }
    }
}
