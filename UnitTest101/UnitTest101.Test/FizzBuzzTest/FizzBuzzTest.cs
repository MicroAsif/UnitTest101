using System;
using System.Collections.Generic;
using System.Text;
using UnitTest101.Lib.FizzBuzz;
using Xunit;

namespace UnitTest101.Test.FizzBuzzTest
{
    public class FizzBuzzTest
    {
        [Theory]
        [InlineData(1, "1")]
        [InlineData(6, "Fizz")]
        [InlineData(10, "Buzz")]
        [InlineData(15, "FizzBuzz")]
        public void FizzBuzz(int n, string m)
        {
            Assert.Equal(m, FizzBuzzCal.GetValue(n));
        }
    }
}
