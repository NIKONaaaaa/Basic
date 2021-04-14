namespace MultiplicationTable
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int digit = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{digit} X {i} = {digit * i}");
            }
        }
    }
}