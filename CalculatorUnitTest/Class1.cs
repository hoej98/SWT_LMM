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
    }
}