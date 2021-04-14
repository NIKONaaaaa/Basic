namespace GenericCountMethodStrings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class StartUp
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            List<string> data = new List<string>();
            for (int i = 0; i < count; i++)
            {
                data.Add(Console.ReadLine());
            }
            string comparator = Console.ReadLine();
            Console.WriteLine(GetCountOfGreaterElements(data, comparator));
        }
        static int GetCountOfGreaterElements<T>(IEnumerable<T> data, T comparator) where T : IComparable
        {
            return data.Count(entry => entry.CompareTo(comparator) > 0);
        }
    }
}