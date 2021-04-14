namespace PalindromeIntegers
{
    using System;
    class StartUp
    {
        static void Main()
        {
            PalindromeCheck(Console.ReadLine());
            static void PalindromeCheck(string input)
            {
                while (true)
                {
                    if (input == "END") break;
                    Console.WriteLine(String.CompareOrdinal(input, Reversal(input)) == 0 ? "true" : "false");
                    input = Console.ReadLine();
                }
            }
            static string Reversal(string stringInput)
            {
                char[] input = stringInput.ToCharArray();
                Array.Reverse(input);
                return new string(input);
            }
        }
    }
}