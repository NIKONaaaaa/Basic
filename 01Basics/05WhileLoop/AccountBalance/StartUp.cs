namespace AccountBalance
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            double moneyTotal = 0;
            string input = "";
            for (; ; )
            {
                input = Console.ReadLine();
                if (input != "NoMoreMoney")
                {
                    double moneyIncrease = double.Parse(input);
                    if (moneyIncrease < 0)
                    {
                        Console.WriteLine("Invalid operation!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Increase: {moneyIncrease:f2}");
                        moneyTotal += moneyIncrease;
                    }
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine($"Total: {moneyTotal:f2}");
        }
    }
}