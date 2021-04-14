namespace PrintPartOfASCIITable
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            for (int i = start; i <= end; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}