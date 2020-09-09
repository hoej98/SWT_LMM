using System;
using NUnit.Framework;
using SoftwareTest_0;

namespace MyCalculator.test.unit
{
    [TestFixture]
    public class TestCalculator
    {
        [Test]
        public void Add_IsCorrect()
        {
            // arrange
            var uut = new Calculator();

            //act

            //uut.Add(7, 17);

            //Assert
            Assert.That(uut.Add(7,17), Is.EqualTo((24)));
        }

        [Test]
        public void Sub_IsCorrect()
        {
            // arrange
            var uut = new Calculator();

            //act

            //

            //Assert
            Assert.That(uut.Subtract(7, 17), Is.EqualTo((-10)));
        }

        [Test]
        public void Mul_IsCorrect()
        {
            // arrange
            var uut = new Calculator();

            //act

            //

            //Assert
            Assert.That(uut.Multiply(7, 17), Is.EqualTo((119)));
        }

        [Test]
        public void Pow_IsCorrect()
        {
            // arrange
            var uut = new Calculator();

            //act

            //

            //Assert
            Assert.That(uut.Power(10, 2), Is.EqualTo((100)));
        }
    }
}