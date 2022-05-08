using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class CoinFlipper
    {
        public void coinFlipLogic()
        {
            int headCount= 0;
            int tailCount= 0;

            //Take user input on no of times to flip the coin
            Console.Write("Please Enter The number of times you wnt to flip the coin: ");
            int input = Convert.ToInt32(Console.ReadLine());
            
            Random randNum = new Random();
            //double flipValue = randNum.NextDouble();
            
            //Flip the coins according to the input
            for (int i = 1; i <= input; i++)
            {
                if (randNum.NextDouble() < 0.5)
                {
                    tailCount++;
                }
                else
                {
                    headCount++;
                }
            }
            //Find percentage of heads and tails and print the values
            double headPercent = (double)headCount / input * 100;
            double tailPercent = (double)tailCount / input * 100;
            Console.WriteLine("Heads  : {0}", headCount);
            Console.WriteLine("Tails  : {0}", tailCount);
            Console.WriteLine("input : {0}",input);
            Console.WriteLine("Heads Percentage : {0}", headPercent);
            Console.WriteLine("Tais Percentage : {0}",tailPercent) ;

        }
    }
}
