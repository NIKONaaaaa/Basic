namespace DefiningClasses
{
    using System;
    using Microsoft.VisualBasic;
    public class DateModifier
    {
        string firstDate;
        string secondDate;
        long difference;
        public static long DaysBetween(string firstDate, string secondDate)
        {
            DateTime fromDate = DateTime.Parse(firstDate);
            DateTime toDate = DateTime.Parse(secondDate);
            return DateAndTime.DateDiff(DateInterval.Day, fromDate, toDate);
        }
    }
}