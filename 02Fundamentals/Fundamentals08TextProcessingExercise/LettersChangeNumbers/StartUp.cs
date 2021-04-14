namespace LettersChangeNumbers
{
    using System;
    class StartUp
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            decimal result = 0;
            foreach (string entry in input)
            {
                char letterOne = char.Parse(entry[0].ToString()), letterTwo = char.Parse(entry[^1].ToString());
                decimal number = decimal.Parse(entry[1..^1]);
                if (97 <= letterOne)
                {
                    number *= (letterOne - 96);
                }
                else
                {
                    number /= (letterOne - 64);
                }
                if (97 <= letterTwo)
                {
                    number += (letterTwo - 96);
                }
                else
                {
                    number -= (letterTwo - 64);
                }
                result += number;
            }
            Console.WriteLine($"{result:f2}");
        }
    }
}