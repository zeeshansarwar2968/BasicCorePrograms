using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class RemainderQuotient
    {
        public void CalculationLogic()
        {
            //Taking in numeric inputs from user
            Console.Write("Please Enter the dividend : ");
            int dividend = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please Enter the divisor : ");
            int divisor = Convert.ToInt32(Console.ReadLine());

            //Logic to calculate quotient and remainder
            int remainder;
            int quotient = Math.DivRem(dividend,divisor,out remainder);
            

            Console.WriteLine("The quotient is : " + quotient);
            Console.WriteLine("The remainder is : "+remainder);

        }

    }
}
