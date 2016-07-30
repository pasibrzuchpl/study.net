using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Sort
    { //bubble sorting algoritm
        public void sort(double[] Array, int n)
        {
            double buffor;
            //double loop for sorting
            for (int i = n - 1; i > 0; i--)
                for (int j = 0; j < i; j++)
                {
                    if (Array[j]> Array[j+1])
                    {
                        buffor = Array[j];
                        Array[j] = Array[j + 1];
                        Array[j + 1] = buffor;
                    }
                }
            foreach (double d in Array)
            {
                Console.Write(d + ", ");
            }
        }
    }
}
