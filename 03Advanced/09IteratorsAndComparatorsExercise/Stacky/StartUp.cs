namespace Stacky
{
    using System;
    class StartUp
    {
        static void Main()
        {
            Stacky<int> myStack = new Stacky<int>();
            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] commands = command.Split(new[] { " ", ", " }, StringSplitOptions.RemoveEmptyEntries);
                string action = commands[0];
                if (action == "Push")
                {
                    for (int i = 1; i < commands.Length; i++)
                    {
                        int item = int.Parse(commands[i]);
                        myStack.Push(item);
                    }
                }
                else if (action == "Pop")
                {
                    try
                    {
                        myStack.Pop();
                    }
                    catch (InvalidOperationException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                command = Console.ReadLine();
            }

            foreach (int item in myStack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(string.Join(Environment.NewLine, myStack));
        }
    }
}