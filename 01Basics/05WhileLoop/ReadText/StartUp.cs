namespace ReadText
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            while (text != "Stop")
            {
                Console.WriteLine(text);
                text = Console.ReadLine();
            }
        }
    }
}