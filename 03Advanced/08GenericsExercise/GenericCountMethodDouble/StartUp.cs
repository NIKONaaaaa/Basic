namespace GenericCountMethodDouble
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class StartUp
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            List<double> data = new List<double>();
            for (int i = 0; i < count; i++)
            {
                data.Add(double.Parse(Console.ReadLine()));
            }
            double comparator = double.Parse(Console.ReadLine());
            Console.WriteLine(GetCountOfGreaterElements(data, comparator));
        }
        static int GetCountOfGreaterElements<T>(IEnumerable<T> data, T comparator) where T : IComparable
        {
            return data.Count(entry => entry.CompareTo(comparator) > 0);
        }
    }
}