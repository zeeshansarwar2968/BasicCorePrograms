using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class HarmonicNumber
    {
        public void harmonicNumberLogic()
        {
            //Taking in number input from user
            Console.Write("Please Enter a Number greater than zero : ");
            int inputNum = Convert.ToInt32(Console.ReadLine());

            double sum = 0;


            //compute 1/1 + 1/2 + 1/3 + ... + 1/N
            for (int i = 1; i <= inputNum; i++)
            {                                                            
                sum = sum + ((double)1 / i);                            
            }

            Console.Write("The Harmonic number is: "+sum);

        }
    }
}
