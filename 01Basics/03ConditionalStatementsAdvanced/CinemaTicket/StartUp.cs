namespace CinemaTicket
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine().ToLower();
            int ticketPrice = 0;
            switch (day)
            {
                case "monday":
                case "tuesday":
                case "friday":
                        ticketPrice = 12;
                    break;
                case "wednesday":
                case "thursday":
                        ticketPrice = 14;
                    break;
                case "saturday":
                case "sunday":
                        ticketPrice = 16;
                    break;
            }
            Console.WriteLine($"{ticketPrice}");
        }
    }
}