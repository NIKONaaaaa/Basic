namespace MaxNumber
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int numberMax = int.MinValue;
            string input = "";
            for (; ; )
            {
                input = Console.ReadLine();
                if (input != "Stop")
                {
                    if (numberMax < int.Parse(input))
                    {
                        numberMax = int.Parse(input);
                    }
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(numberMax);
        }
    }
}