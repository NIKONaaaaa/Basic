namespace BikeRace
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            double juniorNumber = double.Parse(Console.ReadLine());
            double juniorFee = 5.5;
            double seniorNumber = double.Parse(Console.ReadLine());
            double seniorFee = 7;
            string contestType = Console.ReadLine();
            switch (contestType)
            {
                case "cross-country":
                    juniorFee = 8;
                    seniorFee = 9.5;
                    break;
                case "downhill":
                    juniorFee = 12.25;
                    seniorFee = 13.75;
                    break;
                case "road":
                    juniorFee = 20;
                    seniorFee = 21.5;
                    break;
            }
            double entryDiscount = 1;
            if (50 <= (juniorNumber + seniorNumber) && contestType == "cross-country")
            {
                entryDiscount = 0.75;
            }
            double expenses = 0.95;
            Console.WriteLine($"{(juniorFee * juniorNumber + seniorFee * seniorNumber) * entryDiscount * expenses:f2}");
        }
    }
}