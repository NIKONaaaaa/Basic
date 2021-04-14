namespace Tuple
{
    using System;
    using System.Linq;
    public class StartUp
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            Tuple<string, string> tuple = new Tuple<string, string>($"{input[0]} {input[1]}", input[2]);
            Console.WriteLine($"{tuple.FirstEntry} -> {tuple.SecondEntry}");

            input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            Tuple<string, int> tupleTwo = new Tuple<string, int>(input[0], int.Parse(input[1]));
            Console.WriteLine($"{tupleTwo.FirstEntry} -> {tupleTwo.SecondEntry}");

            input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            Tuple<int, double> tupleThree = new Tuple<int, double>(int.Parse(input[0]), double.Parse(input[1]));
            Console.WriteLine($"{tupleThree.FirstEntry} -> {tupleThree.SecondEntry}");
        }
    }
}