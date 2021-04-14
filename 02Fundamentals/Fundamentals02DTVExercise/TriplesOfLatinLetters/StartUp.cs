namespace TriplesOfLatinLetters
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    for (int k = 0; k < number; k++)
                    {
                        Console.Write((char)('a' + i)); 
                        Console.Write((char)('a' + j)); 
                        Console.Write((char)('a' + k));
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}