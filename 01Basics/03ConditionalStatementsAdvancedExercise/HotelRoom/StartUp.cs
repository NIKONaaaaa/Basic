namespace HotelRoom
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            string monthName = Console.ReadLine().ToLower();
            int daysNumber = int.Parse(Console.ReadLine());
            double studioPrice = 76;
            double apartmentPrice = 77;
            double studioDiscount = 1;
            double apartmentDiscount = 1;
            if (14 < daysNumber)
            {
                apartmentDiscount = 0.9;
            }
            switch (monthName)
            {
                case "may":
                case "october":
                    studioPrice = 50;
                    apartmentPrice = 65;
                    if (7 < daysNumber && daysNumber <= 14)
                    {
                        studioDiscount = 0.95;
                    }
                    else if (14 < daysNumber)
                    {
                        studioDiscount = 0.7;
                    }
                    break;
                case "june":
                case "september":
                    studioPrice = 75.2;
                    apartmentPrice = 68.7;
                    if (14 < daysNumber)
                    {
                        studioDiscount = 0.8;
                    }
                    break;
            }
            Console.WriteLine($"Apartment: {daysNumber * apartmentPrice * apartmentDiscount:f2} lv.");
            Console.WriteLine($"Studio: {daysNumber * studioPrice * studioDiscount:f2} lv.");
        }
    }
}