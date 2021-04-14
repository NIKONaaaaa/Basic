namespace Snowballs
{
    using System;
    using System.Numerics;
    class StartUp
    {
        static void Main()
        {
            int snowballNumber = int.Parse(Console.ReadLine()), snowballQualityMax = 0, snowballSnowMax = 0, snowballTimeMax = 0;
            BigInteger snowballValueMax = 0;
            for (int i = 1; i <= snowballNumber; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);
                if (snowballValueMax <= snowballValue)
                {
                    snowballValueMax = snowballValue;
                    snowballQualityMax = snowballQuality;
                    snowballSnowMax = snowballSnow;
                    snowballTimeMax = snowballTime;
                }
            }
            Console.WriteLine($"{snowballSnowMax} : {snowballTimeMax} = {snowballValueMax} ({snowballQualityMax})");
        }
    }
}