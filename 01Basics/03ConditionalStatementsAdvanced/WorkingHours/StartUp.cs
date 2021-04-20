namespace WorkingHours
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            string day = Console.ReadLine().ToLower();
            string status = "";
            switch (day)
            {
                case "monday":
                case "tuesday":
                case "wednesday":
                case "thursday":
                case "friday":
                case "saturday":
                        if (10 <= hour && hour <= 18)
                        {
                            status = "open";
                        }
                        else
                        {
                            status = "closed";
                        }
                    break;
                case "sunday":
                        status = "closed";
                    break;
            }
            Console.WriteLine($"{status}");
        }
    }
}