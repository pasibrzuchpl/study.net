using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class PrimeNumber
    {
        public int L(int N)
        {   //first prime number = 2
            int i = 2;
            int j = 2 ;
            int low = 3;
            int ans=0;

            //algoritm
            while (i <= N)
            {
                while(j <= i - 1)
                {
                    if (low % j == 0)
                        break;
                    j++;

                }

                if (j == i)
                {
                    ans = low;
                    i++;
                }

                low++;
                
            }
            return ans;
            

        } 
 
     }
}
