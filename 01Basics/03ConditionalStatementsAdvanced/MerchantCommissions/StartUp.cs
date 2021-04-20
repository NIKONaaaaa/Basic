namespace TradeCommissions
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            string cityName = Console.ReadLine().ToLower();
            double salesVolume = double.Parse(Console.ReadLine());
            double salesCommission = 0;
            switch (cityName)
            {
                case "sofia":
                    if (0 <= salesVolume && salesVolume <= 500)
                    {
                        salesCommission = 0.05;
                    }
                    if (500 < salesVolume && salesVolume <= 1000)
                    {
                        salesCommission = 0.07;
                    }
                    if (1000 < salesVolume && salesVolume <= 10000)
                    {
                        salesCommission = 0.08;
                    }
                    if (10000 < salesVolume)
                    {
                        salesCommission = 0.12;
                    }
                    break;
                case "varna":
                    if (0 <= salesVolume && salesVolume <= 500)
                    {
                        salesCommission = 0.045;
                    }
                    if (500 < salesVolume && salesVolume <= 1000)
                    {
                        salesCommission = 0.075;
                    }
                    if (1000 < salesVolume && salesVolume <= 10000)
                    {
                        salesCommission = 0.10;
                    }
                    if (10000 < salesVolume)
                    {
                        salesCommission = 0.13;
                    }
                    break;
                case "plovdiv":
                    if (0 <= salesVolume && salesVolume <= 500)
                    {
                        salesCommission = 0.055;
                    }
                    if (500 < salesVolume && salesVolume <= 1000)
                    {
                        salesCommission = 0.08;
                    }
                    if (1000 < salesVolume && salesVolume <= 10000)
                    {
                        salesCommission = 0.12;
                    }
                    if (10000 < salesVolume)
                    {
                        salesCommission = 0.145;
                    }
                    break;
            }
            if ((cityName != "sofia" && cityName != "varna" && cityName != "plovdiv") || salesVolume < 0)
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine($"{salesVolume * salesCommission:f2}");
            }
        }
    }
}