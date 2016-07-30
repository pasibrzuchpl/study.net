using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Choose size of Array");
            int size = Convert.ToInt32(Console.ReadLine());


            //our array to sorting
            double[] Array = new double[size];

            //random number
            Random random = new Random(1000);

            //array filling
            for (int i = 0; i < size; i++)
            {
                Array[i] = random.Next(0, 100);
            }

            Console.WriteLine("Random array of values:");
            foreach (double d in Array)
            {
                Console.Write(d + ", ");
            }

            Sort s = new Sort();

            Console.WriteLine("\nSorted array");
            s.sort(Array, size);


            Console.ReadKey();

        }
    }
}
