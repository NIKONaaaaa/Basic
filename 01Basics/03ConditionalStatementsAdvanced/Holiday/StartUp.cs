namespace WeekendOrWorkingDay
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            string dayName = Console.ReadLine().ToLower();
            string dayType = "";
            switch (dayName)
            {
                case "monday":
                case "tuesday":
                case "wednesday":
                case "thursday":
                case "friday":
                    dayType = "Working day";
                    break;
                case "saturday":
                case "sunday":
                    dayType = "Weekend";
                    break;
                default:
                    dayType = "Error";
                    break;
            }
            Console.WriteLine($"{dayType}");
        }
    }
}