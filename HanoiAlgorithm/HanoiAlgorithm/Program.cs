using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Tower of Hanoi algoritm 
Program main method 
from http://www.sanfoundry.com/csharp-program-tower-of-hanoi/ */



namespace HanoiAlgorithm
{
    class Program
    {
 
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter amount of discs");
            string amoutOfDiscs = Console.ReadLine();

            //new tower class object
            Tower t = new Tower();
            //accessor to value and converting to int from string
            t.NumberOfDiscs = Convert.ToInt32(amoutOfDiscs);
            //call method to solve
            t.MoveTower(t.NumberOfDiscs, 1, 3, 2);

            Console.ReadLine();


        }
    }
}
