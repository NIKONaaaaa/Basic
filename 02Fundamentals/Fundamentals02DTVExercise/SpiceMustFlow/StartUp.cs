namespace SpiceMustFlow
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int yieldExpected = int.Parse(Console.ReadLine()), yieldTotal = 0, dayCounter = 0;
            if (yieldExpected < 100)
            {
                Console.WriteLine(dayCounter);
                Console.WriteLine(yieldTotal);
            }
            else
            {
                while (100 <= yieldExpected)
                {
                    yieldTotal += yieldExpected - 26;
                    yieldExpected -= 10;
                    dayCounter++;
                }
                Console.WriteLine(dayCounter);
                Console.WriteLine(yieldTotal - 26);
            }
        }
    }
}