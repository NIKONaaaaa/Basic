namespace SafePasswordsGenerator
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());
            int passwordMax = int.Parse(Console.ReadLine());
            int j = 35, u = 64;
            bool check = true;
            while (35 <= j && j <= 55)
            {
                if (check == false)
                {
                    break;
                }
                while (64 <= u && u <= 96)
                {
                    if (check == false)
                    {
                        break;
                    }
                    for (int o = 1; o <= one; o++)
                    {
                        if (check == false)
                        {
                            break;
                        }
                        for (int p = 1; p <= two; p++)
                        {
                            if (check == false)
                            {
                                break;
                            }
                            for (int i = 1; i <= passwordMax; i++)
                            {
                                Console.Write($"{(char)j}{(char)u}{o}{p}{(char)u}{(char)j}|");
                                j++;
                                u++;
                                if (passwordMax == i)
                                {
                                    check = false;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}