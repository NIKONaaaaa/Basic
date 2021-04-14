namespace ReverseString
{
    using System;
    class StartUp
    {
        static void Main()
        {
            string input = Console.ReadLine();
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            string output = new string(charArray);
            Console.WriteLine(output);
        }
    }
}