namespace CarNumber
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            for (int i = numberOne; i <= numberTwo; i++)
            {
                for (int j = numberOne; j <= numberTwo; j++)
                {
                    for (int u = numberOne; u <= numberTwo; u++)
                    {
                        for (int y = numberOne; y < numberTwo; y++)
                        {
                            if (((i % 2 == 00 && y % 2 == 1) || (i % 2 == 1 && y % 2 == 0)) && (j + u) % 2 == 0 && i > y)
                            {
                                Console.Write($"{i}{j}{u}{y} ");
                            }
                        }
                    }
                }
            }
        }
    }
}