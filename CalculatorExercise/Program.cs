using System;
using System.Dynamic;

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
        public double Accumulator {get; private set; }

        public void Clear()
        {
            Accumulator = 0;
        }

        public double Add(double a, double b)
        {
            double value = a + b;   //Calculates value

            Accumulator = value;    //Sets Accumulator
            return value;           //Returns value
        }

        public double Subtract(double a, double b)
        {
            double value = a - b;

            Accumulator = value;
            return value;
        }

        public double Multiply(double a, double b)
        {
            double value = a * b;

            Accumulator = value;
            return value;
        }

        public double Power(double x, double exp)
        {
            double value = Math.Pow(x, exp);

            Accumulator = value;
            return value;
        }

        public double Divide(double a, double b)
        {
            double value = a / b;

            Accumulator = value;
            return value;
        }

        public double sqrt(double a)
        {
            double value = sqrt(a);

            Accumulator = value;
            return value;
        }
    }
}


