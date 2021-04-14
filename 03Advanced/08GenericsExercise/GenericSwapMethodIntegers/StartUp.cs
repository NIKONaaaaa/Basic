namespace GenericSwapMethodIntegers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class StartUp
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            List<int> data = new List<int>();
            for (int i = 0; i < count; i++)
            {
                data.Add(int.Parse(Console.ReadLine()));
            }
            int[] indices = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Swap(data, indices);
            Print(data);
        }
        public static void Swap<T>(List<T> data, int[] indices)
        {
            T swapper = data[indices[0]];
            data[indices[0]] = data[indices[1]];
            data[indices[1]] = swapper;
        }
        public static void Print<T>(List<T> data)
        {
            foreach (T entry in data)
            {
                Console.WriteLine($"{entry.GetType()}: {entry}");
            }
        }
    }
}