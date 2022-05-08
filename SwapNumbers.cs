using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class SwapNumbers
    {
        public void swapLogic()
        {
            //Taking in numeric inputs from user
            Console.Write("Please Enter number n1 : ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please Enter number n2 : ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before swap the numbers are n1= " + n1 + " n2= " + n2);

            //Logic to swap the numbers without a third variable

            n1 = n1 * n2;

            n2 = n1 / n2;

            n1 = n1 / n2;

            Console.WriteLine("After swap the numbers are n1= " + n1 + " n2= " + n2);


        }

    }
}
