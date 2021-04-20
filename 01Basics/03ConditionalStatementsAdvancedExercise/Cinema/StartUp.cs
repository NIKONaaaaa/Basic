namespace Cinema
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            string showType = Console.ReadLine().ToLower();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            double revenue = 0;
            switch (showType)
            {
                case "premiere":
                    revenue = rows * columns * 12;
                    break;
                case "normal":
                    revenue = rows * columns * 7.5;
                    break;
                case "discount":
                    revenue = rows * columns * 5;
                    break;
            }
            Console.WriteLine($"{revenue:f2} leva");
        }
    }
}