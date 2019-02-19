using System;
using Xunit;
using Calculator_app;


namespace xunit_Test
{
   
    public class xunitTest
    {

        [Fact]
        public void TestAdd()
        {
            CalculatorApp calc = new CalculatorApp();
            double expected = 6.0;
            double actual = calc.Add(2.0, 4.0);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestDivide()
        {
            //Arrange
            CalculatorApp calc = new CalculatorApp();
            double expected = 2.0;
            //Act
            double actual = calc.Divide(4.0, 2.0);
            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestMultiply()
        {
            CalculatorApp calc = new CalculatorApp();
            double expected = 4.0;
            double actual = calc.Multiply(2.0, 2.0);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestModulo()
        {
            CalculatorApp calc = new CalculatorApp();
            double expected = 0.0;
            double actual = calc.Modulo(4.0, 2.0);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestAreaOfTriangle()
        {
            CalculatorApp calc = new CalculatorApp();
            double expected = 17.5;
            double actual = calc.AreaOfTriangle(7.0, 5.0);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestAreaOfSquare()
        {
            CalculatorApp calc = new CalculatorApp();
            double expected = 25.0;
            double actual = calc.AreaOfsquare(5.0, 5.0);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestAreaOfRectangle()
        {
            CalculatorApp calc = new CalculatorApp();
            double expected = 14.0;
            double actual = calc.AreaOfsquare(7.0, 2.0);
            Assert.Equal(expected, actual);
        }
    }
}
