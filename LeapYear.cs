using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class LeapYear
    {
        public void leapYearLogic()
        {
            //Logic:
            //1. Any year that is divisible by 400 is definitely a leap year.
            //2. If it is not divisible by 400, then check if it is divisible by 100, if so, then it is NOT a leap year (even if it is divisible by 4), and
            //3. If the above two conditions are not satisfied we check for divisibility by 4, if it is divisible by 4 it is a leap year.

            Console.Write("Please Enter The Year: ");
            int year = Convert.ToInt32(Console.ReadLine());


            //Logic implementation to check for leap year
            if (year % 4 == 0)
            {                                                           
                if (year % 100 == 0)
                {                                                   
                    if (year % 400 == 0)
                    {                                                
                        Console.WriteLine("This is a Leap Year") ;                                  
                    }
                    else
                    {
                        Console.WriteLine("This is not a Leap Year");                               

                    }
                }
                else
                {
                    Console.WriteLine("This is a Leap Year");                                  
                }
            }
            else
            {
                Console.WriteLine("This is a not Leap Year");                                  

            }
        }

    }
}
