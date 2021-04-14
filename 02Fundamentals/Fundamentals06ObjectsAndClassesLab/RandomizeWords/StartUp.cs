namespace RandomizeWords
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            Console.WriteLine(RandomWords(Console.ReadLine()));
            static string RandomWords(string input)
            {
                List<string> wordList = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                Random randomNumber = new Random();
                for (int positionOne = 0; positionOne < wordList.Count; positionOne++)
                {
                    int positionTwo = randomNumber.Next(wordList.Count);
                    string wordOne = wordList[positionOne], wordTwo = wordList[positionTwo];
                    wordList.Insert(positionOne + 1, wordTwo);
                    wordList.RemoveAt(positionOne);
                    wordList.Insert(positionTwo + 1, wordOne);
                    wordList.RemoveAt(positionTwo);
                }
                return string.Join(Environment.NewLine, wordList);
            }
        }
    }
}