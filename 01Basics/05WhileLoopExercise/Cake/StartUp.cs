namespace Cake
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int cakeWidth = int.Parse(Console.ReadLine());
            int cakeLength = int.Parse(Console.ReadLine());
            int cakeSize = cakeLength * cakeWidth;
            string input = Console.ReadLine();
            while (0 < cakeSize && input != "STOP")
            {
                cakeSize -= int.Parse(input);
                input = Console.ReadLine();
            }
            if (0 <= cakeSize)
            {
                Console.WriteLine($"{cakeSize} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(cakeSize)} pieces more.");
            }
        }
    }
}