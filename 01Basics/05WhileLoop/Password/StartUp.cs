namespace Password
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();
            string passwordInput = Console.ReadLine();
            while (password != passwordInput)
            {
                passwordInput = Console.ReadLine();
            }
            Console.WriteLine($"Welcome {username}!");
        }
    }
}