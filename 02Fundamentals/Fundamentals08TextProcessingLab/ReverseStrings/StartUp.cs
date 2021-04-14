namespace ReverseStrings
{
    using System;
    class StartUp
    {
        static void Main()
        {
            string input = Console.ReadLine();
            while (input != "end")
            {
                Console.WriteLine($"{input} = {Reverse(input)}");
                input = Console.ReadLine();
            }
        }
        private static string Reverse(string word)
        {
            string reverseWord = "";
            for (int i = word.Length - 1; 0 <= i; i--)
            {
                reverseWord += word[i];
            }
            return reverseWord;
        }
    }
}