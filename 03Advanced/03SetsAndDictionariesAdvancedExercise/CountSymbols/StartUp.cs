namespace CountSymbols
{
    using System;
    using System.Collections.Generic;
    class StartUp
    {
        static void Main()
        {
            string input = Console.ReadLine();
            SortedDictionary<char, int> symbols = new SortedDictionary<char, int>();
            foreach (char ch in input)
            {
                if (symbols.ContainsKey(ch))
                {
                    symbols[ch]++;
                }
                else
                {
                    symbols.Add(ch, 1);
                }
            }
            foreach (var (ch, times) in symbols)
            {
                Console.WriteLine($"{ch}: {times} time/s");
            }
        }
    }
}