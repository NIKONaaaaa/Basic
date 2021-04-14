namespace ConcatNames
{
    using System;
    class StartUp
    {
        static void Main()
        {
            string nameOne = Console.ReadLine();
            string nameTwo = Console.ReadLine();
            string delimiter = Console.ReadLine();
            Console.WriteLine($"{nameOne}{delimiter}{nameTwo}");
        }
    }
}