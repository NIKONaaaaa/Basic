namespace RepeatString
{
    using System;
    class StartUp
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());
            Console.WriteLine(StringRepeater(input, multiplier));
        }
        private static string StringRepeater(string str, int count)
        {
            string result = string.Empty;
            for (int i = 1; i <= count; i++) result += str;
            return result;
        }
    }
}