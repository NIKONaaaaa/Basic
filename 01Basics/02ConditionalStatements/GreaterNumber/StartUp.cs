﻿namespace GreaterNumber
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int grnum = Math.Max(num1, num2);
                Console.WriteLine($"{grnum}");
        }
    }
}