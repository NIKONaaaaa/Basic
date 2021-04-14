namespace ValidUsernames
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            List<string> input = Console.ReadLine().Split(", ").ToList();
            for (int i = 0; i < input.Count; i++)
            {
                if (3 > input[i].Length || input[i].Length > 16)
                {
                    input.Remove(input[i]);
                    i--;
                }
                else
                {
                    string word = input[i];
                    for (int j = 0; j < word.Length; j++)
                    {
                        if (!char.IsLetterOrDigit(word[j]) && word[j] != '-' && word[j] != '_')
                        {
                            input.Remove(word);
                            i--;
                            break;
                        }
                    }
                }
            }
            Console.Write(string.Join(Environment.NewLine, input));
        }
    }
}