using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class PrimeNumber
    {
        public static void L(int N)
        {   //first prime number = 2
            int PrimeNumber = 3, count=2, c=2, ans=0;

            if (N == 1)
                Console.WriteLine(2);

            while(count <= N)
            {
                for (c = 2; c <= PrimeNumber - 1; c++)
                {
                    if (PrimeNumber % c == 0)
                        break;
                }
                if (c == PrimeNumber)
                {
                    ans = PrimeNumber;
                    count++;
                }
                PrimeNumber++;

            
            }
            Console.WriteLine(ans);
            

        }
    }
}
