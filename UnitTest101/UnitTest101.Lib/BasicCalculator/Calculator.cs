using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest101.Lib.BasicCalculator
{
    public static class Calculator
    {
        public static double Add(double num1, double num2) => num1 + num2;
        public static double Sub(double num1, double num2) => num1 - num2;
        public static double Mul(double num1, double num2) => num1 * num2;
        public static double Div(double num1, double num2) => num1 / num2;
    }
}
