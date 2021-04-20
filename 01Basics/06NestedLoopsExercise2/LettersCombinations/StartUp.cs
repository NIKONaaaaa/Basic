namespace LettersCombinations
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int a = char.Parse(Console.ReadLine());
            int b = char.Parse(Console.ReadLine());
            int c = char.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = a; i <= b; i++)
            {
                for (int j = a; j <= b; j++)
                {
                    for (int u = a; u <= b; u++)
                    {
                        if (i != c && j != c && u != c)
                        {
                            Console.Write($"{(char)i}{(char)j}{(char)u} ");
                            counter++;
                        }
                    }
                }
            }
            Console.Write(counter);
        }
    }
}