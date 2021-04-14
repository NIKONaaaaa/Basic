namespace CharactersInRange
{
    using System;
    class StartUp
    {
        static void Main()
        {
            PrintRange(char.Parse(Console.ReadLine()), char.Parse(Console.ReadLine()));
            static void PrintRange(char a, char b)
            {
                for (int i = Math.Min(a, b) + 1; i < Math.Max(a, b); i++) Console.Write($"{(char)i} ");
            }
        }
    }
}