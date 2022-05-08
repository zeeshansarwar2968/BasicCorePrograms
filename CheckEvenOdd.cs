using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class CheckEvenOdd
    {
        public void evenOddLogic()
        {
            //Taking in numeric input from user
            Console.Write("Please Enter number to check for even/odd : ");
            int inputNum = Convert.ToInt32(Console.ReadLine());

            if(inputNum%2 == 0)
            {
                Console.WriteLine("");
                Console.WriteLine("The number is even");
            }else
            {
                Console.WriteLine("");
                Console.WriteLine("The number is odd");

            }
        }
    }
}
