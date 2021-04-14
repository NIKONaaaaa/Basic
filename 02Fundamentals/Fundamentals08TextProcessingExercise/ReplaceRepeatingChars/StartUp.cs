namespace ReplaceRepeatingChars
{
    using System;
    using System.Collections.Generic;
    class StartUp
    {
        static void Main()
        {
            string input = Console.ReadLine();
            List<char> result = new List<char>();
            foreach (char character in input)
            {
                result.Add(character);
            }
            for (int i = 0; i < result.Count - 1; i++)
            {
                if (result[i] == result[i + 1])
                {
                    result.RemoveAt(i);
                    i--;
                }
            }
            Console.WriteLine(string.Join("", result));
        }
    }
}