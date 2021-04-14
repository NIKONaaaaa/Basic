namespace MonthPrinter
{
    using System;
    using System.Globalization;
    class StartUp
    {
        static void Main()
        {
            int month = int.Parse(Console.ReadLine());
            if (1 <= month && month <= 12)
            {
                string monthName = CultureInfo.GetCultureInfo("en-GB").DateTimeFormat.GetMonthName(month);
                Console.WriteLine($"{monthName}");
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}