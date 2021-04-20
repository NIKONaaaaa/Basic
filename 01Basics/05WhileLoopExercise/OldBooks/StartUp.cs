namespace OldBooks
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            string bookRequired = Console.ReadLine();
            int bookCount = 0;
            bool check = true;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == bookRequired)
                {
                    Console.WriteLine($"You checked {bookCount} books and found it.");
                    check = false;
                    break;
                }
                if (input == "No More Books")
                {
                    break;
                }
                bookCount++;
            }
            if (check)
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {bookCount} books.");
            }
        }
    }
}