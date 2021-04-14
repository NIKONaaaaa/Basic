namespace RecursiveFactorial
{
    using System;
    class StartUp
    {
        static void Main()
        {
            Console.WriteLine(GetFactorial(int.Parse(Console.ReadLine())));
        }
        public static long GetFactorial(int number)
        {
            if (number == 1)
            {
                return 1;
            }
            return number * GetFactorial(number - 1);
        }
    }
}