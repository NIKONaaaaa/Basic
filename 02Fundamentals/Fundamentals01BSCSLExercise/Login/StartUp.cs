namespace Login
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            string userName = Console.ReadLine(), password = string.Concat(userName.Reverse());
            int failCount = 0;
            while (true)
            {
                string passwordInput = Console.ReadLine();
                if (passwordInput == password)
                {
                    Console.WriteLine($"User {userName} logged in.");
                    break;
                }
                else
                {
                    failCount++;
                    if (failCount == 4)
                    {
                        Console.WriteLine($"User {userName} blocked!");
                        break;
                    }
                    Console.WriteLine("Incorrect password. Try again.");
                }
            }
        }
    }
}