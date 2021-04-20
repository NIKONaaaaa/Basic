namespace Firm
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            double overTimeWork = double.Parse(Console.ReadLine());
            double training = (days * 0.1);
            double overtime = (overTimeWork * days * 2);
            double totalHours = ((days - training) * 8 + overtime);
            if (totalHours >= hours)
            {
                Console.WriteLine($"Yes!{Math.Floor(totalHours - hours)} hours left.");
            }
            else
            {
                Console.WriteLine($"Not enough time!{Math.Ceiling(hours - totalHours)} hours needed.");
            }
        }
    }
}