using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppAnimalsTwo.Model;

namespace ConsoleAppAnimalsTwo.Model
{
    public class Cat:Animals
    {
        public override void SaySomething()
        {
            Console.WriteLine("Cats say Meow");
        }
    }
}
