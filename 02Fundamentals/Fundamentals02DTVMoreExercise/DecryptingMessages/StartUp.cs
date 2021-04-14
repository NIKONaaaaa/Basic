namespace DecryptingMessages
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int key = int.Parse(Console.ReadLine());
            int counter = int.Parse(Console.ReadLine());
            string output = "";
            for (int i = 1; i <= counter; i++)
            {
                char ch = char.Parse(Console.ReadLine());
                char numeric = (char)(ch + key);
                output += numeric;
            }
            Console.WriteLine(output);
        }
    }
}