namespace OnTimeForExam
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinute = int.Parse(Console.ReadLine());
            int differenceSum = (arrivalHour * 60 + arrivalMinute) - (examHour * 60 + examMinute);
            if (differenceSum < 0)
            {
                differenceSum = Math.Abs(differenceSum);
                if (differenceSum >= 60)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{differenceSum / 60}:{differenceSum % 60:d2} hours before the start");
                }
                else if (differenceSum <= 30)
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{differenceSum} minutes before the start");
                }
                else
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{differenceSum} minutes before the start");
                }
            }
            else if (differenceSum >= 60)
            {
                Console.WriteLine("Late");
                Console.WriteLine($"{differenceSum / 60}:{differenceSum % 60:d2} hours after the start");
            }
            else if (differenceSum > 0)
            {
                Console.WriteLine("Late");
                Console.WriteLine($"{differenceSum} minutes after the start");
            }
            else
            {
                Console.WriteLine("On time");
            }
        }
    }
}