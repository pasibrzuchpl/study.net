using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*algoritm to solve problem*/

namespace HanoiAlgorithm
{
    
    class Tower
    {
       private int numberOfDiscs;


        //blanck constructor
       public Tower()
        {
            numberOfDiscs = 0;
        }
        //method with parameter
        public Tower(int v)
        {
            numberOfDiscs = v;
        }

        //accesors
        public int NumberOfDiscs
        {
            get
            {
                return numberOfDiscs;
            }
            
            set
            {
                if (value > 0)
                    numberOfDiscs = value;
            }
        }

        //metod to move discs
        public void MoveTower(int n, int from, int to, int other)
        {
            if (n > 0)
            {
                MoveTower(n - 1, from, other, to);
                Console.WriteLine("Move disk {0} from tower {1} to tower {2}", n, from, to);
                MoveTower(n - 1, other, to, from);
            }

        }

    }
}
