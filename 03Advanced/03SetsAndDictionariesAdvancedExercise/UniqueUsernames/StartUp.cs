namespace UniqueUsernames
{
    using System;
    using System.Collections.Generic;
    class StartUp
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            HashSet<string> names = new HashSet<string>();
            for (int i = 0; i < count; i++)
            {
                names.Add(Console.ReadLine());
            }
            Console.WriteLine(string.Join(Environment.NewLine, names));
        }
    }
}