using System;
using Task1_Calculator.Interfaces;

namespace Task1_Calculator.Services
{
    public class MathService : IMath
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Divide(double a, double b)
        {
            if(b == 0)
            {
                throw new Exception("Invalid");
            }
            return a / b;
        }
    }
}