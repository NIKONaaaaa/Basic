namespace WeddingSeats
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int sector = char.Parse(Console.ReadLine());
            int rows = int.Parse(Console.ReadLine());
            int spaces = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 'A'; i <= sector; i++)
            {
                for (int j = 1; j <= rows; j++)
                {
                    if (j % 2 == 0)
                    {
                        for (int u = 'a'; u < spaces + 2 + 'a'; u++)
                        {
                            Console.WriteLine($"{(char)i}{j}{(char)u}");
                            count++;
                        }
                    }
                    else
                    {
                        for (int u = 'a'; u < spaces + 'a'; u++)
                        {
                            Console.WriteLine($"{(char)i}{j}{(char)u}");
                            count++;
                        }
                    }
                }
                rows++;
            }
            Console.WriteLine(count);
        }
    }
}