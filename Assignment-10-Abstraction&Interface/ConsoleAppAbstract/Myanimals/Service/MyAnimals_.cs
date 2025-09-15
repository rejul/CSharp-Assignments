using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Myanimals.Model;

namespace MyAnimals.Service
{
    public class MyAnimals_:Animal,IMammal
    {
        private int bodyTemp;

        // Property with get/set accessors
        public int BodyTemp
        {
            get { return bodyTemp; }
            set { bodyTemp = value; }
        }

        // Implementation of abstract method (and IMammals method)
        public override int GetBodyTemp()
        {
            return BodyTemp;   // Ensure property is used
        }
    }
}
