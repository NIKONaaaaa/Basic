namespace MetricConverter
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            double entrynumber = double.Parse(Console.ReadLine());
            string entryunit = Console.ReadLine();
            string convunit = Console.ReadLine();
            if (entryunit == "mm" && convunit == "cm")
            {
                Console.WriteLine($"{entrynumber / 10:f3}");
            }
            else if (entryunit == "mm" && convunit == "m")
            {
                Console.WriteLine($"{entrynumber / 1000:f3}");
            }
            else if (entryunit == "cm" && convunit == "mm")
            {
                Console.WriteLine($"{entrynumber * 10:f3}");
            }
            else if (entryunit == "cm" && convunit == "m")
            {
                Console.WriteLine($"{entrynumber / 100:f3}");
            }
            else if (entryunit == "m" && convunit == "mm")
            {
                Console.WriteLine($"{entrynumber * 1000:f3}");
            }
            else if (entryunit == "m" && convunit == "cm")
            {
                Console.WriteLine($"{entrynumber * 100:f3}");
            }
        }
    }
}