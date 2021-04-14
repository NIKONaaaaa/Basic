namespace LineNumbers
{
    using System;
    using System.IO;
    using System.Text.RegularExpressions;
    class StartUp
    {
        static void Main()
        {
            string[] lines = File.ReadAllText("../../../text.txt").Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = $"Line {i + 1}: {lines[i]} ({Regex.Matches(lines[i], @"[\w]").Count})({Regex.Matches(lines[i], @"[-,.!?']").Count})";
            }
            File.WriteAllText("../../../textOut.txt", string.Join(Environment.NewLine, lines));
        }
    }
}