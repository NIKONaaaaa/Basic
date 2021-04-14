namespace BeerKegs
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine()), height;
            string kegType, kegLargest = "";
            double radius, volumeMax = 0.0;
            for (int i = 1; i <= number; i++)
            {
                kegType = Console.ReadLine();
                radius = double.Parse(Console.ReadLine());
                height = int.Parse(Console.ReadLine());
                if (volumeMax < Math.PI * radius * radius * height)
                {
                    kegLargest = kegType;
                    volumeMax = Math.PI * radius * radius * height;
                }
            }
            Console.WriteLine(kegLargest);
        }
    }
}