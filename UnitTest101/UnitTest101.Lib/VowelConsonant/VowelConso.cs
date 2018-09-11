using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest101.Lib.VowelConsonant
{
    // this function will print first vowel letter than consonant letter
    public static class VowelConso
    {
        public static string GetLetter(string word)
        { 
            string output = "";
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u')
                    output += word[i];
            }

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != 'a' && word[i] != 'e' && word[i] != 'i' && word[i] != 'o' && word[i] != 'u')
                    output += word[i];
            }
            return output;
        }
    }
}
