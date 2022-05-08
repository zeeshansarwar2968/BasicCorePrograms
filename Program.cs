using System;

namespace BasicCorePrograms
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic Core Programs in C-Sharp");
            Console.WriteLine("");
            CoinFlipper coinFlipper = new CoinFlipper();
            coinFlipper.coinFlipLogic();
            Console.ReadKey();
        }
    }
}
