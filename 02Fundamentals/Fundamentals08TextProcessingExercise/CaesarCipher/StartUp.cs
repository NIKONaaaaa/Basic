namespace CaesarCipher
{
    using System;
    class StartUp
    {
        static void Main()
        {
            string input = Console.ReadLine(), output = null;
            for (int i = 0; i < input.Length; i++)
            {
                output += (char)(input[i] + 3);
            }
            Console.WriteLine(output);
        }
    }
}