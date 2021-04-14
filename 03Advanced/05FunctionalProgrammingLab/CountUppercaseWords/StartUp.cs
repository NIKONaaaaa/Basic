namespace CountUppercaseWords
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            static bool CheckUppercase(string word) => word[0] == word.ToUpper()[0];
            string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Where(CheckUppercase).ToArray();
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}