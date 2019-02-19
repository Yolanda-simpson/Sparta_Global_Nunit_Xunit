using System;
using NUnit.Framework;
using Calculator_app;

namespace Nunit_Calculator
{
    [TestFixture]
    public class NUnitTest1
    {


        [Test] //attribute must be here to be able to test the method
        public void TestAdd()
        {
            CalculatorApp calc = new CalculatorApp();
            double expected = 6.0;
            double actual = calc.Add(2.0, 4.0);
            Assert.AreEqual(expected, actual);
        }
        [Test ]//attribute must be here to be able to test the method
        public void TestDivide()
        {
            //Arrange
            CalculatorApp calc = new CalculatorApp();
            double expected = 2.0;
            //Act
            double actual = calc.Divide(4.0, 2.0);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestMultiply()
        {
            CalculatorApp calc = new CalculatorApp();
            double expected = 4.0;
            double actual = calc.Multiply(2.0, 2.0);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestModulo()
        {
            CalculatorApp calc = new CalculatorApp();
            double expected = 0.0;
            double actual = calc.Modulo(4.0, 2.0);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestAreaOfTriangle()
        {
            CalculatorApp calc = new CalculatorApp();
            double expected = 17.5;
            double actual = calc.AreaOfTriangle(7.0, 5.0);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestAreaOfSquare()
        {
            CalculatorApp calc = new CalculatorApp();
            double expected = 25.0;
            double actual = calc.AreaOfsquare(5.0, 5.0);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestAreaOfRectangle()
        {
            CalculatorApp calc = new CalculatorApp();
            double expected = 14.0;
            double actual = calc.AreaOfsquare(7.0, 2.0);
            Assert.AreEqual(expected, actual);
        }
    }
}

   

