namespace AdvertisementMessage
{
    using System;
    class StartUp
    {
        static void Main()
        {
            Advertisement.PrintRandom(int.Parse(Console.ReadLine()));
        }
    }
    class Advertisement
    {
        static readonly string[] Phrase = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
        static readonly string[] Event = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
        static readonly string[] Author = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
        static readonly string[] City = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
        public static void PrintRandom(int advertNumberMax)
        {
            for (int i = 0; i < advertNumberMax; i++)
            {
                Console.WriteLine($"{Phrase[GetRandom(Phrase)]} {Event[GetRandom(Event)]} {Author[GetRandom(Author)]} – {City[GetRandom(City)]}.");
            }
        }
        private static int GetRandom(string[] infoArray)
        {
            return new Random().Next(infoArray.Length);
        }
    }
}