using System;
using System.Collections.Generic;
using System.Text;
using UnitTest101.Lib.DemeritePointCalcultor;
using Xunit;

namespace UnitTest101.Test.DemeritePointCalculatorTest
{
    public class DemeritePointCalculatorTest
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(65, 0)]
        [InlineData(120, 11)]
        public void DemeritePointTest(int speed, int result)
        {
            //asset 

            Assert.Equal(DemeritePoint.CalculateDemeritePoints(speed), result);
        }

        
    }
}
