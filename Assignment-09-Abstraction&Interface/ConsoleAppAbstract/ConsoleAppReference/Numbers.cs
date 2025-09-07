using ConsoleAppReference.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppReference
{
    public class Numbers : IFirst, ISecond
    {
        private int value;

        public Numbers(int v)
        {
            value = v;
        }

        // Explicit implementation for IFirst.Display
        void IFirst.Display()
        {
            Console.WriteLine($"IFirst Display: Value = {value}");
        }

        // Explicit implementation for ISecond.Display
        void ISecond.Display()
        {
            Console.WriteLine($"ISecond Display: Value = {value}");
        }

        // Normal implementation for IFirst.GetValue
        public int GetValue()
        {
            return value;
        }

        // Normal implementation for ISecond.Demo
        public void Demo()
        {
            Console.WriteLine("ISecond Demo method called.");
        }
    }

}
