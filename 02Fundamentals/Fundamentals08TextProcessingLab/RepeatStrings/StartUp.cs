namespace RepeatStrings
{
    using System;
    using System.Text;
    class StartUp
    {
        static void Main()
        {
            string[] words = Console.ReadLine().Split();
            StringBuilder result = new StringBuilder();
            foreach (string word in words)
            {
                foreach (char letter in word)
                {
                    result.Append(word);
                }
            }
            Console.WriteLine(result);
        }
    }
}