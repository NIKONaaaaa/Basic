namespace DepositCalculator
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double deposit = double.Parse(Console.ReadLine());
            int time = int.Parse(Console.ReadLine());
            double apr = double.Parse(Console.ReadLine());
            double monthlyApr = deposit * apr / 12 / 100;
            double sum = deposit + time * monthlyApr;
            Console.WriteLine(sum);
        }
    }
}