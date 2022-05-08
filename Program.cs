using System;

namespace BasicCorePrograms
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic Core Programs in C-Sharp");
            Console.WriteLine("");
            //CoinFlipper coinFlipper = new CoinFlipper();
            //coinFlipper.coinFlipLogic();
            //LeapYear leapYear = new LeapYear();
            //leapYear.leapYearLogic();

            //Power2 power2 = new Power2();
            //power2.powerOf2logic();

            HarmonicNumber harmonicNumObj = new HarmonicNumber();
            harmonicNumObj.harmonicNumberLogic();
            Console.ReadKey();
        }
    }
}
