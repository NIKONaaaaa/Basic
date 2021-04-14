namespace TreasureFinder
{
    using System;
    using System.Linq;
    using System.Text;
    class StartUp
    {
        static void Main()
        {
            int[] keys = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string input = Console.ReadLine();
            while (input != "find")
            {
                StringBuilder output = new StringBuilder();
                int index = 0;
                foreach (char ch in input)
                {
                    if (keys.Length - 1 < index)
                    {
                        index = 0;
                    }
                    output.Append((char)(ch - keys[index]));
                    index++;
                }
                string message = output.ToString();
                string type = message[(message.IndexOf('&') + 1)..message.LastIndexOf('&')];
                string coordinates = message[(message.IndexOf('<') + 1)..message.LastIndexOf('>')];
                Console.WriteLine($"Found {type} at {coordinates}");
                input = Console.ReadLine();
            }
        }
    }
}