using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class Program
    {/* PROGRAM TO FINDING PRIME NUMBER BY THEY ORDER
        e.g. L(10)=47, because 47 is 10th prime number*/

        static void Main(string[] args)
        {
            Console.WriteLine("Type L(N) to find:");
            int n = Convert.ToInt32(Console.ReadLine());

            PrimeNumber L = new PrimeNumber();
            L.L(n);

        }
    }
}
