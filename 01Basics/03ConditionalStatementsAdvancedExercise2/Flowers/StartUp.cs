namespace Flowers
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            double chrisantemeNumber = double.Parse(Console.ReadLine());
            double roseNumber = double.Parse(Console.ReadLine());
            double tulipNumber = double.Parse(Console.ReadLine());
            double chrisantemePrice = 2;
            double rosePrice = 4.1;
            double tulipPrice = 2.5;
            const double arrangementPrice = 2;
            double holidayIncrease = 1;
            double discountOne = 1;
            double discountTwo = 1;
            double discountThree = 1;
            string season = Console.ReadLine().ToLower();
            if (season == "autumn" || season == "winter")
            {
                chrisantemePrice = 3.75;
                rosePrice = 4.5;
                tulipPrice = 4.15;
            }
            string holidayCheck = Console.ReadLine();
            if (holidayCheck == "Y")
            {
                holidayIncrease = 1.15;
            }
            if (7 < tulipNumber && season == "spring")
            {
                discountOne = 0.95;
            }
            if (10 <= roseNumber && season == "winter")
            {
                discountTwo = 0.9;
            }
            if (20 < (chrisantemeNumber + roseNumber + tulipNumber))
            {
                discountThree = 0.8;
            }
            Console.WriteLine($"{((chrisantemeNumber * chrisantemePrice + roseNumber * rosePrice + tulipNumber * tulipPrice) * holidayIncrease * discountOne * discountTwo * discountThree + arrangementPrice):f2}");
        }
    }
}