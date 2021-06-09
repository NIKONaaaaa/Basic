namespace EvenLines
{
    using System;
    using System.Linq;
    using System.IO;
    using System.Text.RegularExpressions;
    class StartUp
    {
        static void Main()
        {
            //using (StreamWriter writer = new StreamWriter("../../../textOut.txt"))
            //{
            using (StreamReader reader = new StreamReader("../../../text.txt"))
            {
                int counter = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    if (counter % 2 == 0)
                    {
                        string replacement = Regex.Replace(line, @"[-,.!?]", "@");
                        string[] reversedReplacement = replacement.Split(" ", StringSplitOptions.RemoveEmptyEntries).Reverse().ToArray();
                        //writer.WriteLine(string.Join(" ", reversedReplacement));
                        Console.WriteLine(string.Join(" ", reversedReplacement));
                    }
                    counter++;
                    line = reader.ReadLine();
                }
            }
            //}
        }
    }
}