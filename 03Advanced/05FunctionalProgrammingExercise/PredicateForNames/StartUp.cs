namespace PredicateForNames
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            int maxLength = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            static bool Filter(string name, int maxLength) => name.Length <= maxLength;
            Console.WriteLine(string.Join(Environment.NewLine, names.Where(name => Filter(name, maxLength))));
        }
    }
}