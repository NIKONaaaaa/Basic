namespace CinemaTickets
{
    using System;
    class StartUp
    {
        static void Main()
        {
            string input = "";
            string movieName = Console.ReadLine();
            double seatsTaken = 0;
            double ticketsTotal = 0;
            double ticketsStudent = 0;
            double ticketsStandard = 0;
            double ticketsKid = 0;
            while (movieName != "Finish")
            {
                double seatsTotal = double.Parse(Console.ReadLine());
                while (seatsTaken < seatsTotal && input != "End" && input != "Finish")
                {
                    input = Console.ReadLine();
                    if (input == "student")
                    {
                        ticketsStudent++;
                        ticketsTotal++;
                        seatsTaken++;
                    }
                    else if (input == "standard")
                    {
                        ticketsStandard++;
                        ticketsTotal++;
                        seatsTaken++;
                    }
                    else if (input == "kid")
                    {
                        ticketsKid++;
                        ticketsTotal++;
                        seatsTaken++;
                    }
                }
                Console.WriteLine($"{movieName} - {seatsTaken / seatsTotal * 100:f2}% full.");
                movieName = Console.ReadLine();
                seatsTaken = 0;
                input = "";
            }
            Console.WriteLine($"Total tickets: {ticketsTotal}");
            Console.WriteLine($"{ticketsStudent / ticketsTotal * 100:f2}% student tickets.");
            Console.WriteLine($"{ticketsStandard / ticketsTotal * 100:f2}% standard tickets.");
            Console.WriteLine($"{ticketsKid / ticketsTotal * 100:f2}% kids tickets.");
        }
    }
}