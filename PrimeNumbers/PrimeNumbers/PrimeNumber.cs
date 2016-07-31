using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class PrimeNumber
    {
        public void L(int N)
        {
            int i, j;
            int low = 3;
            int ans;


            for (i = 2; i <= N;)
            {
                for (j = 2; j <= i - 1; j++)
                {
                    if (low % j == 0)
                        break;
                }
                if (j == i)
                {
                    ans = low;
                    i++;
                }
                low++;
                
            }
            Console.WriteLine(ans);
            Console.ReadKey();

        } 

            
           
        }
    }
