namespace MiddleCharacters
{
    using System;
    class StartUp
    {
        static void Main()
        {
            MiddleCharacters(Console.ReadLine());
            static void MiddleCharacters(string input)
            {
                if (input.Length % 2 == 1)
                {
                    Console.WriteLine(input[(input.Length / 2)]);
                }
                else
                {
                    Console.WriteLine($"{input[(input.Length / 2) - 1]}{input[input.Length / 2]}");
                }
            }

        }
    }
}