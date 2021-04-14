namespace ExtractPersonInformation
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int lineNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < lineNumber; i++)
            {
                string input = Console.ReadLine();
                string name = input.Substring(input.IndexOf('@') + 1, input.IndexOf('|') - (input.IndexOf('@') + 1));
                string age = input.Substring(input.IndexOf('#') + 1, input.IndexOf('*') - (input.IndexOf('#') + 1));
                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}