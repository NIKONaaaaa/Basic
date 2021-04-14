namespace BalancedBrackets
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int counter = int.Parse(Console.ReadLine());
            bool open = false, close = true;
            for (int i = 0; i < counter; i++)
            {
                string input = Console.ReadLine();
                if (input == "(")
                {
                    if (!open)
                    {
                        open = true;
                    }
                    else
                    {
                        close = false;
                    }
                }
                if (input == ")")
                {
                    if (open)
                    {
                        open = false;
                    }
                    else
                    {
                        close = false;
                    }
                }
            }
            if (close && !open)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}