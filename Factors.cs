using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class Factors
    {
        public void factorsLogic()
        {
            //Getting input from user
            Console.Write("Please Enter The Number to check for prime factors: ");
            int inputNum = Convert.ToInt32(Console.ReadLine());

            
            Console.Write("Factors= 1");
            //Logic to print out prime factors for the given number
            for (int i = 2; i * i <= inputNum; i++)
            {                                                                     
                while (inputNum % i == 0)
                    
                {                                                    
                    Console.Write(i + " ");                
                    inputNum = inputNum / i;
                }
            }

            // For the number when after the loop and finding all the prime factors and to print the number itself as it also is a factor            
            if (inputNum > 1)
            {
                Console.Write(inputNum);
            }
            Console.WriteLine();
            
        }
    }
}
