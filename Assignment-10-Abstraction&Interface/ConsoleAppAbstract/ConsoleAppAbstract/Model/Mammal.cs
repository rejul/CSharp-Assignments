using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAbstract.Model
{
    public class Mammal : IMammals
    {
        public int GetBodyTemp(string bodyPart)
        {
            if (string.IsNullOrEmpty(bodyPart))
            {
                Console.WriteLine("You need to enter a value");
            }

            if (int.TryParse(bodyPart, out int bResult))
            {
                Console.WriteLine("You entered a valid temp");
                return bResult;
            }
            else
            {
                throw new FormatException("Invalid Input");
            }

    


        }
    }
}
