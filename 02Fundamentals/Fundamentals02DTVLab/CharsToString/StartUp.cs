namespace CharsToString
{
    using System;
    class StartUp
    {
        static void Main()
        {
            char[] input = new char[3];
            string output = "";
            for (int i = 0; i <= 2; i++)
            {
                input[i] = char.Parse(Console.ReadLine());
            }
            for (int j = 0; j <= 2; j++)
            {
                output += input[j];
            }
            Console.WriteLine(output);
        }
    }
}