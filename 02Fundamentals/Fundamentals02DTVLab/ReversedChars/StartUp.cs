namespace ReversedChars
{
    using System;
    class StartUp
    {
        static void Main()
        {
            char[] input = new char[3];
            for (int i = 0; i <= 2; i++)
            {
                input[i] = char.Parse(Console.ReadLine());
            }
            Array.Reverse(input);
            for (int j = 0; j <= 2; j++)
            {
                Console.Write($"{input[j]} ");
            }
        }
    }
}