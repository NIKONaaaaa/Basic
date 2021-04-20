namespace LuckyNumbers
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    for (int u = 1; u <= 9; u++)
                    {
                        for (int y = 1; y <= 9; y++)
                        {
                            if ((i + j) == (u + y) && input % (i + j) == 0)
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