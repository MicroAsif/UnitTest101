using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using UnitTest101.Lib;
using UnitTest101.Lib.BasicCalculator;

namespace UnitTest101.Test.BasicCalculator
{
    
    public class BasicCalculatorTest
    {
        [InlineData(10, 12)]
        [InlineData(5.5, 6.5)]
        [InlineData(8, 9.7)]
        [Theory]
        public void AddMethod(double n1, double n2)
        {
            //assert
            Assert.Equal(n1+n2, Calculator.Add(n1, n2));
        }

        [InlineData(10, 12)]
        [InlineData(5.5, 6.5)]
        [InlineData(8, 9.7)]
        [Theory]
        public void SubMethod(double n1, double n2)
        {
            //assert
            Assert.Equal(n1 - n2, Calculator.Sub(n1, n2));
        }

        [InlineData(10, 12)]
        [InlineData(5.5, 6.5)]
        [InlineData(8, 9.7)]
        [Theory]
        public void MulMethod(double n1, double n2)
        {
            //assert
            Assert.Equal(n1 * n2, Calculator.Mul(n1, n2));
        }

        [InlineData(10, 12)]
        [InlineData(5.5, 6.5)]
        [InlineData(8, 9.7)]
        [Theory]
        public void DivMethod(double n1, double n2)
        {
            //assert
            Assert.Equal(n1 / n2, Calculator.Div(n1, n2));
        }
    }
}
