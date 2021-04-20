namespace TransportPrice
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();
            double taxiStart = 0.7;
            double taxiDay = 0.79;
            double taxiNight = 0.9;
            double bus = 0.09;
            double train = 0.06;
            if (distance >= 100)
            {
                Console.WriteLine($"{train * distance:f2}");
            }
            else if (distance >= 20)
            {
                Console.WriteLine($"{bus * distance:f2}");
            }
            else if (time == "day")
            {
                Console.WriteLine($"{taxiStart + taxiDay * distance:f2}");
            }
            else
            {
                Console.WriteLine($"{taxiStart + taxiNight * distance:f2}");
            }
        }
    }
}