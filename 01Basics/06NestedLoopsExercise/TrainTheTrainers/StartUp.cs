namespace TrainTheTrainers
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int jurors = int.Parse(Console.ReadLine());
            string presentationName = Console.ReadLine();
            double presentationAverage = 0;
            double presentationCount = 0;
            double totalAverage = 0;
            while (presentationName != "Finish")
            {
                for (int i = 1; i <= jurors; i++)
                {
                    presentationAverage += double.Parse(Console.ReadLine());
                }
                Console.WriteLine($"{presentationName} - {presentationAverage / jurors:f2}.");
                totalAverage += presentationAverage / jurors;
                presentationCount++;
                presentationAverage = 0;
                presentationName = Console.ReadLine();
            }
            Console.WriteLine($"Student's final assessment is {totalAverage / presentationCount:f2}.");
        }
    }
}