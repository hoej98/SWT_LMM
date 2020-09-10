using System;

namespace Calculatorr
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator C = new Calculator();
            double addvalue = C.Add(10, 10);

            Console.WriteLine(addvalue);

            double subvalue = C.Subtract(10, 10);

            Console.WriteLine(subvalue);

            double mulvalue = C.Multiply(10, 10);

            Console.WriteLine(mulvalue);

            double powvalue = C.Power(10, 10);

            Console.WriteLine(powvalue);
        }
    }

    public class Calculator
    {
        public double Add(double a, double b)
        {
            double value = a + b;
            return value;
        }

        public double Subtract(double a, double b)
        {
            double value = a - b;
            return value;
        }

        public double Multiply(double a, double b)
        {
            double value = a * b;
            return value;
        }

        public double Power(double x, double exp)
        {
            double value = Math.Pow(x, exp);
            return value;
        }

        public double Divide(double a, double b)
        {
            double value = a / b;
            return value;
        }
    }
}


