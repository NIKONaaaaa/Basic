namespace Histogram
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            int numberCounter1 = 0;
            int numberCounter2 = 0;
            int numberCounter3 = 0;
            int numberCounter4 = 0;
            int numberCounter5 = 0;
            for (int i = 1; i <= counter; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 400)
                {
                    if (200 <= number)
                    {
                        numberCounter2++;
                    }
                    else
                    {
                        numberCounter1++;
                    }
                }
                else
                {
                    if (number >= 800)
                    {
                        numberCounter5++;
                    }
                    else if (number >= 600)
                    {
                        numberCounter4++;
                    }
                    else
                    {
                        numberCounter3++;
                    }
                }
            }
            Console.WriteLine($"{(1.0 * numberCounter1 / counter) * 100:f2}%");
            Console.WriteLine($"{(1.0 * numberCounter2 / counter) * 100:f2}%");
            Console.WriteLine($"{(1.0 * numberCounter3 / counter) * 100:f2}%");
            Console.WriteLine($"{(1.0 * numberCounter4 / counter) * 100:f2}%");
            Console.WriteLine($"{(1.0 * numberCounter5 / counter) * 100:f2}%");
        }
    }
}