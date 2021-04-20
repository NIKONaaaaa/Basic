namespace MinNumber
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int numberMin = int.MaxValue;
            string input = "";
            for (; ; )
            {
                input = Console.ReadLine();
                if (input != "Stop")
                {
                    if (int.Parse(input) < numberMin)
                    {
                        numberMin = int.Parse(input);
                    }
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(numberMin);
        }
    }
}