using System;
using UnitTest101.Lib.FizzBuzz;

namespace UnitTest101.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(FizzBuzzCal.GetValue(i));
            }
           

            string s = "javascriptloops";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'a' || s[i]== 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u')
                    Console.WriteLine(s[i]);
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != 'a' && s[i] != 'e' && s[i] != 'i' && s[i] != 'o' && s[i] != 'u')
                    Console.WriteLine(s[i]);
            }

            Console.Read();
        }
    }
}
