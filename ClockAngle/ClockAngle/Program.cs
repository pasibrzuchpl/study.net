using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockAngle
{
    /*PROGRAM TO CALCULATE THE ANGLE BETWEEN HANDS OF A CLOCK
     * IN 24 FORMAT
     METHOD HAS STRING TYPE PARAMETER*/



    class Program
    {
        //method to solve problem
        public void angleSolver(string time)
        {
            //deleting ":" from time format
            time = time.Remove(time.IndexOf(":"), 1);

            
            //integers with hour and minutes from string 
            int m = Convert.ToInt32(time.Substring(time.Length-2, 2));
            int h = Convert.ToInt32(time.Remove(time.Length - 2, 2));

            //if hour is greater then 12 [24format]
            if (h > 12)
                h /= 2;

            //calculation for hour hand and minutes hand of clock
            //basicly its angle from the vertical
            double hAngle = h * 30 + (m / 60) * 30;
            double mAngle = m * 6;

            //SOLVE:
            double angle = Math.Abs(mAngle - hAngle);

            Console.WriteLine("Angle between hand of a clock = " + angle);
        }

        //MAIN
        static void Main(string[] args)
        {
            //HOUR
            Console.WriteLine("Type hour: [0-23]");
            string userHour = Console.ReadLine();
            
            //if hour format is wrong
            while(Convert.ToInt32(userHour)>23 || Convert.ToInt32(userHour) < 0)
            {

                Console.WriteLine("Wrong number, type hour [0-23]:");
                userHour = Console.ReadLine();
                
            }
            //deleting white chars
            userHour=userHour.Trim();



            Console.WriteLine("Type hour: [0-60]");
            string userMinutes = Console.ReadLine();

            //if minutes format is wrong
            while (Convert.ToInt32(userMinutes) > 60 || Convert.ToInt32(userMinutes) < 0)
            {

                Console.WriteLine("Wrong number, type minutes: [0-60]:");
                userHour = Console.ReadLine();
                
            }
            //triming white chars
            userMinutes=userMinutes.Trim();


            //concatination of strings in one data string 
            string time = string.Concat(userHour, userMinutes);


            //adding ":" to better format time
            if(Convert.ToInt32(userMinutes)<10)
            {
                //if user typed one digit in minutes, here we add bonus 0 to time
               time= time.Insert(time.Length - 1, ":0");
            }
            else
            {
               time= time.Insert(time.Length - 2, ":");
            }

            
            Console.WriteLine("You typed {0} o'clock", time);

            Program p = new Program();
            p.angleSolver(time);

            Console.ReadKey();

        }
    }
}
