using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastArraySort
{
    class FastSort
    {
        //sorting
        public void Sort(double[] Array, int left, int right)
        {
            //vars
            int l = left;
            int r = right;


            //we need center point's value  in array
            double center = Array[(l + r) / 2];
            double buffor;

            //magic with algoritm
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
                    buffor = Array[l];
                    Array[l] = Array[r];
                    Array[r] = buffor;
                    l++;
                    r--;

                }
            }

            while (l <= r);

            if (left < r)
            {
                Sort(Array, left, r);
            }
            if (right > l)
            {
                Sort(Array, l, right);
            }

            //show sorted array
            foreach (double d in Array)
            {
                Console.Write(d + ", ");
            }

        }


    }
}
