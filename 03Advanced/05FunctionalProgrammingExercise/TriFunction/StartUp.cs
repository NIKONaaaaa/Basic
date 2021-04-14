namespace TriFunction
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            int targetSum = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            static bool SumOfName(string name, int value)
            {
                int sum = 0;
                foreach (char ch in name)
                {
                    sum += ch;
                }
                return sum >= value;
            }
            string FindFirstSum(List<string> names, Func<string, int, bool> criteria)
            {
                foreach (string name in names.Where(name => criteria(name, targetSum)))
                {
                    return name;
                }
                return "";
            }
            Console.WriteLine(FindFirstSum(names, SumOfName));
        }
    }
}