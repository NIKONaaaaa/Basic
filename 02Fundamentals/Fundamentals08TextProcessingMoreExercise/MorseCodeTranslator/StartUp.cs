namespace MorseCodeTranslator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    class StartUp
    {
        static void Main()
        {
            Dictionary<string, string> morseCodeTable = new Dictionary<string, string> {
                { ".-", "A" }, { "-...", "B" }, { "-.-.", "C" }, { "-..", "D" }, { ".", "E" },
                { "..-.", "F" }, { "--.", "G" }, { "....", "H" }, { "..", "I" }, { ".---", "J" },
                { "-.-", "K" }, { ".-..", "L" }, { "--", "M" }, { "-.", "N" }, { "---", "O" },
                { ".--.", "P" }, { "--.-", "Q" }, { ".-.", "R" }, { "...", "S" }, { "-", "T" },
                { "..-", "U" }, { "...-", "V" }, { ".--", "W" }, { "-..-", "X" }, { "-.--" , "Y" },
                { "--.." , "Z" } };
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            StringBuilder output = new StringBuilder();
            foreach (string item in input)
            {
                output.Append(item == "|" ? " " : morseCodeTable[item]);
            }
            Console.WriteLine(output);
        }
    }
}