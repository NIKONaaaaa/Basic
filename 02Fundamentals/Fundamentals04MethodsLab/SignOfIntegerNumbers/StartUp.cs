namespace SignOfIntegerNumbers
{
    using System;
    class StartUp
    {
        static void Main()
        {
            SignCheck(int.Parse(Console.ReadLine()));
        }
        private static void SignCheck(int number)
        {
            string result;
            if (number == 0)
            {
                result = "zero";
            }
            else if (number >= 0)
            {
                result = "positive";
            }
            else
            {
                result = "negative";
            }
            Console.WriteLine($"The number {number} is {result}.");
        }
    }
}