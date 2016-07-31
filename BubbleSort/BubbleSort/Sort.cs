using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Sort
    { //bubble sorting algoritm
      //SORTING IN INCREASING ORDER

        public void sort(double[] Array)
        {
            double buffor;
            //double loop for sorting
            //from the end (lengh-1) to beginning, with deincrementation
            for (int i = Array.Length - 1; i > 0; i--)
                //from 0, to moment when j<i, then there is next loop round of "i"
                for (int j = 0; j < i; j++)
                {   //if number in array is higher then next one in this array
                    if (Array[j]> Array[j+1])
                    {   //new buffor var is needed to save value of higher
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
