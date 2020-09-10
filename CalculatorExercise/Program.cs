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
            Console.WriteLine("addvalue er: {0}", addvalue);


            double subvalue = C.Subtract(10, 10);
            Console.WriteLine("subvalue er: {0}", subvalue);


            double mulvalue = C.Multiply(10, 10);
            Console.WriteLine("mulvalue er: {0}", mulvalue);


            double powvalue = C.Power(10, 10);
            Console.WriteLine("powvalue er: {0}", powvalue);

            double divvalue = C.Divide(10, 10);
            Console.WriteLine("divvalue er: {0}", divvalue);

            Console.WriteLine("Accumulator er: {0}", C.Accumulator);
            Console.Write("Clearing accumulator..\n");
            C.Clear();
            Console.WriteLine("Accumulator er: {0}", C.Accumulator);

            double sqrvalue = C.sqrtOf(49);
            Console.WriteLine("sqrvalue er: {0}", sqrvalue);

            try
            {
                C.Divide(25, 0);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Kan ikke dividere med 0 :(");
            }


            try
            {
                C.sqrtOf(-49);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Kan ikke tage kvadratroden af negative tal :(");
            }
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
            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            else
            {
                double value = a / b;
                Accumulator = value;
                return value;
            }
        }

        public double sqrtOf(double a)
        {
            if (a < 0)
            {
                throw new ArgumentException();
            }
            else
            {
                double value = Math.Sqrt(a);
                Accumulator = value;
                return value;
            }
        }
    }
}


