namespace StreamOfLetters
{
    using System;
    class StartUp
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int letterC = 0;
            int letterO = 0;
            int letterN = 0;
            string message = "";
            string word = "";
            while (input != "End")
            {
                char inputA = char.Parse(input);
                if (inputA == 'c' && letterC == 0)
                {
                    letterC++;
                }
                else if (inputA == 'o' && letterO == 0)
                {
                    letterO++;
                }
                else if (inputA == 'n' && letterN == 0)
                {
                    letterN++;
                }
                else
                {
                    if (Char.IsLetter(inputA))
                    {
                        message += inputA;
                    }
                }
                if (letterC == 1 && letterO == 1 && letterN == 1)
                {
                    word += message += " ";
                    message = "";
                    letterC = 0;
                    letterO = 0;
                    letterN = 0;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(word);
        }
    }
}