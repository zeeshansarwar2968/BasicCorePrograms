using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class LargestNumber
    {
        public void numberCheckLogic()
        {
            //Taking in number inputs from user
            Console.Write("Please Enter Number 1 : ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please Enter Number 2 : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please Enter Number 3 : ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            //Logic to compare the three numbers
            if ((num1 > num2) && (num1 > num3))
            {
                Console.WriteLine("The largest number is:{0}", num1);
            }
            else if ((num2 > num1) && (num2 > num3))
            {
                Console.WriteLine("The largest number is: " + num2);
            }
            else
            {
                Console.WriteLine("The largest number is: " + num3);
            }
        }
    }
}
