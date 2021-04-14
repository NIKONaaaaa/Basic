namespace StrongNumber
{
    using System;
    class StartUp
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int number = int.Parse(input);
            int total = 0;
            foreach (char ch in input)
            {
                int digit = ch - 48;
                int factorial = 1;
                for (int j = 1; j <= digit; j++)
                {
                    factorial *= j;
                }
                total += factorial;
            }
            if (number == total)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}