namespace Coins
{
    using System;
    class StartUp
    {
        static void Main()
        {
            decimal change = decimal.Parse(Console.ReadLine());
            int coinCount = 0;
            decimal[] coinType = { 2, 1, .5m, .2m, .1m, .05m, .02m, .01m };
            int i = 0;
            while (0 < change)
            {
                coinCount += (int)(change / coinType[i]);
                change = change % coinType[i];
                i++;
            }
            Console.WriteLine(coinCount);
        }
    }
}