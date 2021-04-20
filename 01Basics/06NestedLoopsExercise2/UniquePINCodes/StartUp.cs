namespace UniquePINCodes
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int counterOne = int.Parse(Console.ReadLine());
            int counterTwo = int.Parse(Console.ReadLine());
            int counterThree = int.Parse(Console.ReadLine());
            for (int digitOne = 2; digitOne <= counterOne; digitOne += 2)
            {
                for (int digitTwo = 2; (digitTwo <= counterTwo && digitTwo <= 7); digitTwo++)
                {
                    for (int digitThree = 2; digitThree <= counterThree; digitThree += 2)
                    {
                        Console.Write($"{digitOne} {digitTwo} {digitThree}");
                        Console.WriteLine();
                    }
                    if (digitTwo % 2 == 1)
                    {
                        digitTwo++;
                    }
                }
            }
        }
    }
}