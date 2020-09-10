using System;
using NUnit.Framework;

namespace Calculatorr
{
    [TestFixture]
    public class TestCalculator
    {
        [TestCase(10,10, 20)]
        [TestCase(-5, 35, 30)]
        [TestCase(0.22, -2, -1.78)]

        public void Add_IsCorrect(double value, double value2, double result)
        {
            // arrange
            var uut = new Calculator();

            //act

            //uut.Add(7, 17);

            //Assert
            Assert.That(uut.Add(value,value2), Is.EqualTo((result)));
        }


        [TestCase(10, 10, 0)]
        [TestCase(-5, 35, -40)]
        [TestCase(0.22, -2, 2.22)]
        public void Sub_IsCorrect(double value, double value2, double result)
        {
            // arrange
            var uut = new Calculator();

            //act

            //

            //Assert
            Assert.That(uut.Subtract(value, value2), Is.EqualTo((result)));
        }

        [TestCase(10, 10, 100)]
        [TestCase(7, -5,-35)]
        [TestCase(0.25, 10, 2.5)]
        public void Mul_IsCorrect(double value, double value2, double result)
        {
            // arrange
            var uut = new Calculator();

            //act

            //

            //Assert
            Assert.That(uut.Multiply(value, value2), Is.EqualTo((result)));
        }

        [TestCase(10, 2, 100)]
        [TestCase(-5, 2, 25)]
        [TestCase(1.5, 2, 2.25)]
        public void Pow_IsCorrect(double value, double value2, double result)
        {
            // arrange
            var uut = new Calculator();

            //act

            //

            //Assert
            Assert.That(uut.Power(value, value2), Is.EqualTo((result)));
        }

        [TestCase(6, 2, 36)]
        public void AccumulatorPow_IsCorrect(double value, double value2, double result)
        {
            // arrange
            var uut = new Calculator();

            //act (power)
            uut.Power(value, value2);

            //Assert 
            Assert.That(uut.Accumulator, Is.EqualTo((result)));
        }

        [TestCase(51, 24, 75)]
        public void AccumulatorAdd_IsCorrect(double value, double value2, double result)
        {
            // arrange
            var uut = new Calculator();

            //act (addition)
            uut.Add(value, value2);

            //Assert 
            Assert.That(uut.Accumulator, Is.EqualTo((result)));
        }

        [TestCase(18, 6, 3)]
        public void AccumulatorDiv_IsCorrect(double value, double value2, double result)
        {
            // arrange
            var uut = new Calculator();

            //act (divide)
            uut.Divide(value, value2);

            //Assert 
            Assert.That(uut.Accumulator, Is.EqualTo((result)));
        }

        [TestCase(25, 5)]
        [TestCase(6, 1)]
        [TestCase(72, 2)]
        public void AccumulatorClear_IsCorrect(double value, double value2)
        {
            // arrange
            var uut = new Calculator();

            //act (divide and clear)
            uut.Divide(value, value2);
            uut.Clear();

            //Assert 
            Assert.That(uut.Accumulator, Is.EqualTo((0)));
        }

        [TestCase(144, 12)]
        [TestCase(9, 3)]
        [TestCase(49, 7)]
        public void sqrtOf_IsCorrect(double value, double result)
        {
            // arrange
            var uut = new Calculator();

            //act

            //

            //Assert
            Assert.That(uut.sqrtOf(value), Is.EqualTo((result)));
        }
    }
}