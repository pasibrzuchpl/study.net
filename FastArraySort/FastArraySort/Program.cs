using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastArraySort
{/*argoritm to fast sorting of array*/

    class Program
    {
        
        //MAIN
        static void Main(string[] args)
        {

            Console.WriteLine("Choose size of Array");
            int size = Convert.ToInt32(Console.ReadLine());
            

            //our array to sorting
            double[] Array = new double[size];

            //random number
            Random random = new Random(1000);

            //array filling
            for (int i = 0; i<size; i++)
            {
                Array[i] = random.Next(0, 100);
            }

            Console.WriteLine("Random array of values:");
            foreach(double d in Array)
            {
                Console.Write(d + ", ");
            }

            FastSort f = new FastSort();
            
            Console.WriteLine("\nSorted array");
            f.Sort(Array, 0, Array.Length-1);

            
            Console.ReadKey();

        }
    }
}
