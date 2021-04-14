namespace RageExpenses
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int lostCounter = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine()), mousePrice = double.Parse(Console.ReadLine()), keyboardPrice = double.Parse(Console.ReadLine()), displayPrice = double.Parse(Console.ReadLine()), total = 0;
            for (int i = 1; i <= lostCounter; i++)
            {
                if (i % 2 == 0)
                {
                    total += headsetPrice;
                }
                if (i % 3 == 0)
                {
                    total += mousePrice;
                }
                if (i % 6 == 0)
                {
                    total += keyboardPrice;
                }
                if (i % 12 == 0)
                {
                    total += displayPrice;
                }
            }
            Console.WriteLine($"Rage expenses: {total:f2} lv.");
        }
    }
}