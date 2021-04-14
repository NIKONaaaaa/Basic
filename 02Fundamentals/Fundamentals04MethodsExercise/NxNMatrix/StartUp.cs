namespace NxNMatrix
{
    using System;
    class StartUp
    {
        static void Main()
        {
            Matrix(int.Parse(Console.ReadLine()));
            static void Matrix(int a)
            {
                for (int i = 1; i <= a; i++)
                {
                    for (int j = 1; j <= a; j++)
                    {
                        Console.Write($"{a} ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}