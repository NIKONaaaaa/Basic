namespace Volleyball
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            string yearType = Console.ReadLine();
            double additionalGames = 1;
            if (yearType == "leap")
            {
                additionalGames = 1.15;
            }
            double holidayNumber = double.Parse(Console.ReadLine());
            double weekendTravel = double.Parse(Console.ReadLine());
            int weekendTotal = 48;
            Console.WriteLine($"{Math.Floor(((weekendTotal - weekendTravel) * 3 / 4 + weekendTravel + holidayNumber * 2 / 3) * additionalGames)}");
        }
    }
}