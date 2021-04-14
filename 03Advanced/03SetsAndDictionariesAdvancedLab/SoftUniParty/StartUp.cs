namespace SoftUniParty
{
    using System;
    using System.Collections.Generic;
    class StartUp
    {
        static void Main()
        {
            string input = Console.ReadLine();
            HashSet<string> vips = new HashSet<string>();
            HashSet<string> guests = new HashSet<string>();
            while (input != "PARTY")
            {
                if (char.IsDigit(input, 0))
                {
                    vips.Add(input);
                }
                else
                {
                    guests.Add(input);
                }
                input = Console.ReadLine();
            }
            vips.UnionWith(guests);
            input = Console.ReadLine();
            while (input != "END")
            {
                vips.Remove(input);
                input = Console.ReadLine();
            }
            Console.WriteLine($"{vips.Count}\n{string.Join(Environment.NewLine, vips)}");
        }
    }
}