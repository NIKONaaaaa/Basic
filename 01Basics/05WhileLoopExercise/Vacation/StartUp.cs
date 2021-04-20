namespace Vacation
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double moneyReq = double.Parse(Console.ReadLine());
            double moneyCur = double.Parse(Console.ReadLine());
            int dayCount = 0;
            int spendCount = 0;
            while (moneyCur < moneyReq && spendCount < 5)
            {
                string input = Console.ReadLine();
                double moneyInput = double.Parse(Console.ReadLine());
                dayCount++;
                if (input == "spend")
                {
                    moneyCur -= moneyInput;
                    spendCount++;
                    if (moneyCur < 0)
                    {
                        moneyCur = 0;
                    }
                }
                else
                {
                    moneyCur += moneyInput;
                    spendCount = 0;
                }
            }
            if (spendCount == 5)
            {
                Console.WriteLine("You can't save the money." + "\n" + dayCount);
            }
            else
            {
                Console.WriteLine($"You saved the money for {dayCount} days.");
            }
        }
    }
}