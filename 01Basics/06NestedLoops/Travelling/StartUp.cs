namespace Travelling
{
    using System;
    class StartUp
    {
        static void Main()
        {
            while (true)
            {
                string country = Console.ReadLine();
                if (country == "End")
                {
                    break;
                }
                double sumTotal = double.Parse(Console.ReadLine());
                do
                {
                    sumTotal -= double.Parse(Console.ReadLine());
                }
                while (0 < sumTotal);
                Console.WriteLine($"Going to {country}!");
            }
        }
    }
}