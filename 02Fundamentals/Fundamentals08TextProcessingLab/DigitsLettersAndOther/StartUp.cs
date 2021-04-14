namespace DigitsLettersAndOther
{
    using System;
    class StartUp
    {
        static void Main()
        {
            string input = Console.ReadLine(), digits = null, letters = null, symbols = null;
            foreach (char ch in input)
            {
                if (char.IsDigit(ch))
                {
                    digits += ch;
                }
                else if (char.IsLetter(ch))
                {
                    letters += ch;
                }
                else
                {
                    symbols += ch;
                }
            }
            Console.Write($"{digits}\n{letters}\n{symbols}");
        }
    }
}