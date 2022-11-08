using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task1_Calculator.Interfaces
{
    public interface IMath
    {
        double Add(double a, double b);

        double Subtract(double a, double b);

        double Multiply(double a, double b);

        double Divide(double a, double b);
    }
}