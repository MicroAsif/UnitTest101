using System;
using UnitTest101.Lib.DemeritePointCalcultor;
using UnitTest101.Lib.FizzBuzz;
using UnitTest101.Lib.VowelConsonant;

namespace UnitTest101.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            //FizzBuzz Test
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(FizzBuzzCal.GetValue(i));
            }
           
            //First Vowel then Consonant 
            string s = "javascriptloops";
            Console.WriteLine(VowelConso.GetLetter(s));


           Console.WriteLine(DemeritePoint.CalculateDemeritePoints(120));

            Console.Read();
        }
    }
}
