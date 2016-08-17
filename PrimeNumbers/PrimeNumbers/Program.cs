using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class Program
    {/* PROGRAM TO FINDING PRIME NUMBER BY THEY ORDER
        e.g. L(5)=1, because 11 is the 5th prime number*/

        static void Main(string[] args)
        {
            Console.WriteLine("Type L(N) to find:");
            int n = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine("\n{0} prime number is {1}", n, PrimeNumber.L(n));
            Console.ReadKey();


        }
    }
}
