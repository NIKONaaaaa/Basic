namespace ReverseArrayOfStrings
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.Write($"{input[i]} ");
            }
        }
    }
}