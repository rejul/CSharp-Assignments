using System;

namespace ConsoleAppMathCalculator.Model
{
    public class Math
    {
        // methods 
        public virtual double Add(double a, double b)
        {
            return a + b;
        }

        public virtual double Subtract(double a, double b)
        {
            return a - b;
        }

        public virtual double Multiply(double a, double b)
        {
            return a * b;
        }

        public virtual double Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Error: Cannot divide by zero!");
                return double.NaN;
            }
            return a / b;
        }

        public virtual void DisplayResult(double result, string operation)
        {
            Console.WriteLine($"The result of {operation} is: {result}");
        }
    }
}
