namespace ZigZagArrays
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            int counter = int.Parse(Console.ReadLine());
            string[] arrayOne = new string[counter], arrayTwo = new string[counter];
            for (int i = 0; i < counter; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                if (i % 2 == 0)
                {
                    arrayOne[i] = input[0];
                    arrayTwo[i] = input[1];
                }
                else
                {
                    arrayOne[i] = input[1];
                    arrayTwo[i] = input[0];
                }
            }
            Console.WriteLine(string.Join(' ', arrayOne));
            Console.WriteLine(string.Join(' ', arrayTwo));
        }
    }
}