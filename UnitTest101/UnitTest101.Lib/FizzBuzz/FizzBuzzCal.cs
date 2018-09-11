using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest101.Lib.FizzBuzz
{
    public static class FizzBuzzCal
    {
        public static string GetValue(int number)
        {
            string output = "";
            if (number % 3 == 0)
                output += "Fizz";
            if (number % 5 == 0)
                output += "Buzz";
            if (string.IsNullOrEmpty(output))
                output += number.ToString();
            return output;
        }
    }
}
