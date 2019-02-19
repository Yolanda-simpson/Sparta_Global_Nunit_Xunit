using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_app
{
    public class CalculatorApp
    {
        static void Main(string[] args)
        {
        }
        public double Add(double num1, double num2)
        {
            double result = num1 + num2;
            return result;
        }
        public double Divide(double num1, double num2)
        {
            double result = num1 / num2;
            return result;
        }
        public double Multiply(double num1, double num2)
        {
            double result = num1 * num2;
            return result;
        }
        public double Modulo(double num1, double num2)
        {
            double result = num1 % num2;
            return result;
        }
        public double AreaOfTriangle(double num1, double num2)
        {
            double result = num1 * num2 * 0.5;
            return result;
        }
        public double AreaOfsquare(double num1, double num2)
        {
            double result = num1 * num2;
            return result;
        }
        public double AreaOfRectangle(double num1, double num2)
        {
            double result = num1 * num2;
            return result;
        }

    }


}

