using System;
using System.Collections.Generic;
using System.Text;
using UnitTest101.Lib.VowelConsonant;
using Xunit;

namespace UnitTest101.Test.VowelConsonantTest
{
    public class VowelConsonantTest
    {
        [Theory]
        [InlineData("javascriptloops", "aaioojvscrptlps")]
        [InlineData("aapef", "aaepf")]

        public void Test(string input, string output)
        {
            Assert.Equal(output,VowelConso.GetLetter(input));
        }
    }
}
