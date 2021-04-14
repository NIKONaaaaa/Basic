namespace Messaging
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string message = Console.ReadLine(), result = "";
            int sum;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum = Sum(numbers[i]);
                if (sum > message.Length - 1)
                {
                    sum -= message.Length;
                }
                result += message[sum];
                message = message[..sum] + message[(sum + 1)..];
            }
            Console.WriteLine(result);
        }
        private static int Sum(int number)
        {
            int result = 0;
            while (number > 0)
            {
                result += number % 10;
                number /= 10;
            }
            return result;
        }
    }
}