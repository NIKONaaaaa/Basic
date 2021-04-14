namespace SumDigits
{
    using System;
    class StartUp
    {
        static void Main()
        {
            string number = Console.ReadLine();
            int length = number.Length, sum = 0;
            char[] digits = number.ToCharArray();
            for (int i = 0; i < length; i++)
            {
                sum += (digits[i] - 48);
            }
            Console.WriteLine(sum);
        }
    }
}