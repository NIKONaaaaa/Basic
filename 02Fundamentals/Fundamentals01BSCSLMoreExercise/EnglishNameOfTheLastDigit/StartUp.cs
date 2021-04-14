namespace EnglishNameOfTheLastDigit
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int digit = number % 10;
            int[] digits = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string[] names = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            int index = Array.IndexOf(digits, digit);
            Console.WriteLine(names[index]);
        }
    }
}