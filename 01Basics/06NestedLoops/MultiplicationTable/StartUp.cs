﻿namespace MultiplicationTable
{
    using System;
    class StartUp
    {
        static void Main()
        {
            for (int a = 1; a <= 10; a++)
            {
                for (int b = 1; b <= 10; b++)
                {
                    Console.WriteLine($"{a} * {b} = {a * b}");
                }
            }
        }
    }
}