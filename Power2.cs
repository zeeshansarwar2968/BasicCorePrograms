using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class Power2
    {
        public void powerOf2logic()
        {
            //Taking in number input from user
            Console.Write("Please Enter a Number between 0 and 31 : ");
            int inputNum = Convert.ToInt32(Console.ReadLine());

            //Simple for loop to print out all the power values of two
            if(0 <= inputNum && inputNum < 31)
            {
                for (int i = 0; i <= inputNum; i++)
                {
                    Console.WriteLine("2 ^ {0} = {1}", i, Math.Pow(2,i ));
                }

            }
            else
            {
                Console.WriteLine("Wront Input, Please restart the program and enter a Number between 0 and 31");
            }
        }
    }
}
