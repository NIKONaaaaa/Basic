namespace ActionPrint
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            Action<string> print = Console.WriteLine;
            foreach (string name in names)
            {
                print(name);
            }
        }
    }
}