namespace SchoolCamp
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine().ToLower();
            string groupType = Console.ReadLine().ToLower();
            double studentNumber = double.Parse(Console.ReadLine());
            double daysNumber = double.Parse(Console.ReadLine());
            double studentPrice = 0;
            string sportType = "";
            double discount = 1;
            if (10 <= studentNumber && studentNumber < 20)
            {
                discount = 0.95;
            }
            else if (20 <= studentNumber && studentNumber < 50)
            {
                discount = 0.85;
            }
            else if (50 <= studentNumber)
            {
                discount = 0.5;
            }
            if (season == "winter")
            {
                studentPrice = 9.6;
                switch (groupType)
                {
                    case "girls":
                        sportType = "Gymnastics";
                        break;
                    case "boys":
                        sportType = "Judo";
                        break;
                    case "mixed":
                        sportType = "Ski";
                        studentPrice = 10;
                        break;
                }
            }
            else if (season == "spring")
            {
                studentPrice = 7.2;
                switch (groupType)
                {
                    case "girls":
                        sportType = "Athletics";
                        break;
                    case "boys":
                        sportType = "Tennis";
                        break;
                    case "mixed":
                        sportType = "Cycling";
                        studentPrice = 9.5;
                        break;
                }
            }
            else
            {
                studentPrice = 15;
                switch (groupType)
                {
                    case "girls":
                        sportType = "Volleyball";
                        break;
                    case "boys":
                        sportType = "Football";
                        break;
                    case "mixed":
                        sportType = "Swimming";
                        studentPrice = 20;
                        break;
                }
            }
            Console.WriteLine($"{sportType} {studentNumber * studentPrice * daysNumber * discount:f2} lv.");
        }
    }
}