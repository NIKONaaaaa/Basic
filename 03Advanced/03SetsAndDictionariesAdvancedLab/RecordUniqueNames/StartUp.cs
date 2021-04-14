namespace RecordUniqueNames
{
    using System;
    using System.Collections.Generic;
    class StartUp
    {
        static void Main()
        {
            HashSet<string> names = new HashSet<string>();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                names.Add(Console.ReadLine());
            }
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}