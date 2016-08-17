using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anagrams
{
    /*program to checking anagrams*/
    class Program
    {
        static void Main(string[] args)
        {
            string str1, str2;

            Console.WriteLine("Write first word");
            str1 = Console.ReadLine();

            Console.WriteLine("Write second word, which is anagram of first");
            str2 = Console.ReadLine();

            //runing class with method 
            anagram.anagraming(str1, str2);

            Console.ReadKey();
        }
    }
}
