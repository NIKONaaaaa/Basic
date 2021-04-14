namespace KnightsOfHonor
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            Action<string> print = PromoteToSir;
            foreach (string name in names)
            {
                print(name);
            }
        }
        public static void PromoteToSir(string name)
        {
            Console.WriteLine($"Sir {name}");
        }
    }
}