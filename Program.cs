using System;

namespace BasicCorePrograms
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic Core Programs in C-Sharp");
            Console.WriteLine("");
            Console.WriteLine("1.Flip Coin and print percentage of Heads and Tails \n2.Leap Year \n3.Power of 2 " +
                    "\n4.Harmonic Number \n5.Factors");
            
            Console.Write("\nPlease Enter Your Option to choose the program to execute : ");

            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    //// create coinFlipper class object to accessing CoinFlipper class.  
                    CoinFlipper coinFlipper = new CoinFlipper();
                    coinFlipper.coinFlipLogic();
                    break;
                case 2:
                    //// create leapYear class object to accessing LeapYear class. 
                    LeapYear leapYear = new LeapYear();
                    leapYear.leapYearLogic();
                    break;

                case 3:
                    //// create power2 class object to accessing Power2 class. 
                    Power2 power2 = new Power2();
                    power2.powerOf2logic();
                    break;
                case 4:
                    //// create harmonicNumObj class object to accessing HarmonicNumber class. 
                    HarmonicNumber harmonicNumObj = new HarmonicNumber();
                    harmonicNumObj.harmonicNumberLogic();
                    break;
                case 5:
                    //// create primeFactors class object to accessing Factors class. 
                    Factors primeFactors = new Factors();
                    primeFactors.factorsLogic();
                    break;                
                default:
                    Console.WriteLine("Wrong option! please enter option again.");
                    break;
            }

            Console.ReadKey();
        }
    }
}
