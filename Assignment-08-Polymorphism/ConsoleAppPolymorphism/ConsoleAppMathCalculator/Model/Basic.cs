using System;

namespace ConsoleAppMathCalculator.Model
{
    public class Basic : Math
    {
        public override double Add(double a, double b)
        {
            return base.Add(a, b);
        }

        public override double Subtract(double a, double b)
        {
            return base.Subtract(a, b);
        }

        public override double Multiply(double a, double b)
        {
            return base.Multiply(a, b);
        }

        public override double Divide(double a, double b)
        {
            return base.Divide(a, b);
        }

        public override void DisplayResult(double result, string operation)
        {
            base.DisplayResult(result, operation);
        }
    }
}
