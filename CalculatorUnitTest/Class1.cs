using System;
using System.Linq.Expressions;
using NUnit.Framework;

namespace Calculatorr
{
    [TestFixture]
    public class TestCalculator
    {
        [TestCase(10,10, 20)]
        [TestCase(5, -5, 0)]
        [TestCase(0.22, -2, -1.78)]

        public void Add_IsCorrect(double value, double value2, double result)
        {
            // Arrange
            var uut = new Calculator();

            // Act and Assert
            Assert.That(uut.Add(value,value2), Is.EqualTo((result)));
        }


        [TestCase(10, 10, 0)] 
        [TestCase(-5, 35, -40)]
        [TestCase(0.22, -2, 2.22)]
        public void Sub_IsCorrect(double value, double value2, double result)
        {
            // Arrange
            var uut = new Calculator();

            // Act and Assert
            Assert.That(uut.Subtract(value, value2), Is.EqualTo((result)));
        }

        [TestCase(10, 10, 100)]
        [TestCase(7, -5,-35)]
        [TestCase(0.25, 10, 2.5)]
        public void Mul_IsCorrect(double value, double value2, double result)
        {
            // Arrange
            var uut = new Calculator();

            // Act and Assert
            Assert.That(uut.Multiply(value, value2), Is.EqualTo((result)));
        }

        [TestCase(10, 2, 100)]
        [TestCase(-5, 2, 25)]
        [TestCase(2, -2, 0.25)]
        public void Pow_IsCorrect(double value, double value2, double result)
        {
            // Arrange
            var uut = new Calculator();

            // Act and Assert
            Assert.That(uut.Power(value, value2), Is.EqualTo((result)));
        }

        [TestCase(10, 10, 1)]
        [TestCase(30, -3, -10)]
        [TestCase(10.5, -5.25, -2)]
        public void Div_IsCorrect(double value, double value2, double result)
        {
            // Arrange
            var uut = new Calculator();

            // Act and Assert
            Assert.That(uut.Divide(value, value2), Is.EqualTo((result)));
        }

        [TestCase(5,0)]
        [TestCase(-5.5, 0)]
        public void DivByZeroThrow_IsCorrect(double value, double value2)
        {
            // Arrange
            var uut = new Calculator();

            // Act and Assert
            Assert.Throws<DivideByZeroException>(() => uut.Divide(value, value2));
        }

        [TestCase(6, 2, 36)]
        public void AccumulatorPow_IsCorrect(double value, double value2, double result)
        {
            // Arrange
            var uut = new Calculator();

            // Act (power)
            uut.Power(value, value2);

            // Assert 
            Assert.That(uut.Accumulator, Is.EqualTo((result)));
        }

        [TestCase(51, 24, 75)]
        public void AccumulatorAdd_IsCorrect(double value, double value2, double result)
        {
            // Arrange
            var uut = new Calculator();

            // Act (addition)
            uut.Add(value, value2);

            // Assert 
            Assert.That(uut.Accumulator, Is.EqualTo((result)));
        }

        [TestCase(18, 6, 3)]
        public void AccumulatorDiv_IsCorrect(double value, double value2, double result)
        {
            // Arrange
            var uut = new Calculator();

            // Act (divide)
            uut.Divide(value, value2);

            // Assert 
            Assert.That(uut.Accumulator, Is.EqualTo((result)));
        }

        [TestCase(25, 5)]
        [TestCase(-100, 1)]
        [TestCase(0, 0)]
        public void AccumulatorClear_IsCorrect(double value, double value2)
        {
            // Arrange
            var uut = new Calculator();

            // Act (add and clear)
            uut.Add(value, value2);
            uut.Clear();

            // Assert 
            Assert.That(uut.Accumulator, Is.EqualTo((0)));
        }

        [TestCase(144, 12)]
        [TestCase(9, 3)]
        [TestCase(0, 0)]
        public void sqrtOf_IsCorrect(double value, double result)
        {
            // Arrange
            var uut = new Calculator();

            // Act and Assert
            Assert.That(uut.sqrtOf(value), Is.EqualTo((result)));
        }

        [TestCase(-144)]
        public void SqrtOfNegativeThrow_IsCorrect(double value)
        {
            // Arrange
            var uut = new Calculator();

            // Act and Assert
            Assert.Throws<ArgumentException>(() => uut.sqrtOf(value));
        }
    }
}