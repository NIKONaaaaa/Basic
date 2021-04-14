namespace TakeSkipRope
{
    using System;
    using System.Collections.Generic;
    class StartUp
    {
        static void Main()
        {
            string input = Console.ReadLine();
            List<int> digits = new List<int>(), takeList = new List<int>(), skipList = new List<int>();
            List<char> characters = new List<char>();
            foreach (char ch in input)
            {
                if (Char.IsDigit(ch))
                {
                    digits.Add(int.Parse(ch.ToString()));
                }
                else
                {
                    characters.Add(ch);
                }
            }
            for (int i = 0; i < digits.Count; i += 2)
            {
                takeList.Add(digits[i]);
                skipList.Add(digits[i + 1]);
            }
            int index = 0;
            List<char> output = new List<char>();
            for (int i = 0; i < takeList.Count; i++)
            {
                output.AddRange(characters.GetRange(index, takeList[i]));
                index += takeList[i] + skipList[i];
            }
            Console.WriteLine(string.Join("", output));
        }
    }
}