namespace LowerOrUpper
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int input = char.Parse(Console.ReadLine());
            if ('A' <= input && input <= 'Z')
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}