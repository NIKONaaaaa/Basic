namespace VacationBooksList
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int pages = int.Parse(Console.ReadLine());
            double pagesPerHour = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            double hours = pages / pagesPerHour;
            double daysPerBook = hours / days;
            Console.WriteLine(daysPerBook);
        }
    }
}