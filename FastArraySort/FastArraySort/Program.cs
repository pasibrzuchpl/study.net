using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastArraySort
{/*argoritm to fast sorting of array*/

    class Program
    {
        //sorting
        public void FastSort(double[] Array, int left, int right)
        {
            //vars
            int l = left;
            int r = right;


            //we need center point's value  in array
            double center = Array[(l + r) / 2];



            do
            {
                while (Array[l] < center)
                {
                    l++;
                }

                while (Array[r] > center)
                {
                    r--;
                }

                if (l <= r)
                {
                    double buffor = Array[l];
                    Array[l] = Array[r];

                    l++;
                    r--;

                }
            }

            while (l <= r);

            if(left<r)
            {
                FastSort(Array, left, r);
            }
            if(right>l)
            {
                FastSort(Array, l, right);
            }
        }


        //MAIN
        static void Main(string[] args)
        {
        }
    }
}
