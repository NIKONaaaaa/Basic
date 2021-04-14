namespace ArrayManipulator
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] commands = command.Split(" ");
                if (commands[0] == "exchange")
                {
                    if (0 <= int.Parse(commands[1]) && int.Parse(commands[1]) < input.Length)
                    {
                        Exchange(input, int.Parse(commands[1]));
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                else if (commands[0] == "max" || commands[0] == "min")
                {
                    Console.WriteLine(EvenOddMaxMin(input, commands[0], commands[1]));
                }
                else if (commands[0] == "first" || commands[0] == "last")
                {
                    if (int.Parse(commands[1]) <= input.Length)
                    {
                        Console.WriteLine("[" + FirstLast(EvenOdd(input, commands[2]), commands[0], int.Parse(commands[1])) + "]");
                    }
                    else
                    {
                        Console.WriteLine("Invalid count");
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine("[" + string.Join(", ", input) + "]");
        }
        static void Exchange(int[] arr, int splitIndex)
        {
            int[] exchangedArr = new int[arr.Length];
            int indexExchArr = 0;
            for (int i = splitIndex + 1; i < arr.Length; i++)
            {
                exchangedArr[indexExchArr] = arr[i];
                indexExchArr++;
            }
            for (int i = 0; i <= splitIndex; i++)
            {
                exchangedArr[indexExchArr] = arr[i];
                indexExchArr++;
            }
            Array.Copy(exchangedArr, arr, arr.Length);
        }
        static string EvenOddMaxMin(int[] arr, string maxMin, string evenOdd)
        {
            int index = -1, max = int.MinValue, min = int.MaxValue, resultFromModDiv = 0;
            if (evenOdd == "odd")
            {
                resultFromModDiv = 1;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == resultFromModDiv)
                {
                    if (maxMin == "min" && arr[i] <= min)
                    {
                        index = i;
                        min = arr[i];
                    }
                    else if (maxMin == "max" && arr[i] >= max)
                    {
                        index = i;
                        max = arr[i];
                    }
                }
            }
            if (index >= 0)
            {
                return index.ToString();
            }
            return "No matches";
        }
        static int[] EvenOdd(int[] arr, string evenOdd)
        {
            int[] evenOrOdd = new int[arr.Length];
            int index = 0, resultFromModDiv = 0;
            if (evenOdd == "odd")
            {
                resultFromModDiv = 1;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == resultFromModDiv)
                {
                    evenOrOdd[index] = arr[i];
                    index++;
                }
            }
            arr = new int[index];
            Array.Copy(evenOrOdd, arr, index);
            return arr;
        }
        static string FirstLast(int[] arr, string firstLast, int count)
        {
            int[] newArr = new int[arr.Length];
            int index = 0;
            if (firstLast == "first")
            {
                for (int i = 0; i < count && i < arr.Length; i++)
                {
                    newArr[index] = arr[i];
                    index++;
                }
            }
            else if (firstLast == "last")
            {
                if (count > arr.Length)
                {
                    count = arr.Length;
                }
                for (int i = arr.Length - count; i < arr.Length; i++)
                {
                    newArr[index] = arr[i];
                    index++;
                }
            }
            arr = new int[index];
            Array.Copy(newArr, arr, index);
            return string.Join(", ", arr);
        }
    }
}