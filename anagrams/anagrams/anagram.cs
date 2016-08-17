using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anagrams
{
    class anagram
    {
        //static method od faster run in program without creating objects
        public static void anagraming(string str1, string str2)
        {
            //changing to arrays of chars
            char[] firstWord = str1.ToCharArray();
            char[] secondWord = str2.ToCharArray();

            //sorting 
            Array.Sort(firstWord);
            Array.Sort(secondWord);

            //sorted arrays to new string 
            string s1 = new string(firstWord);
            string s2 = new string(secondWord);

            //compering strings
            if (s1 == s2)
                Console.WriteLine("{0} is anagram of {1}", str1, str2);
            else
                Console.WriteLine("That's not anagrams");

        }
    }
}
