namespace Threeuple
{
    using System;
    using System.Linq;
    public class StartUp
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            Threeuple<string, string, string> threeuple = new Threeuple<string, string, string>($"{input[0]} {input[1]}", input[2], string.Join(" ", input.TakeLast(input.Length - 3)));
            Console.WriteLine($"{threeuple.FirstEntry} -> {threeuple.SecondEntry} -> {threeuple.ThirdEntry}");

            input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            Threeuple<string, int, bool> threeupleTwo = new Threeuple<string, int, bool>(input[0], int.Parse(input[1]), input[2] == "drunk");
            Console.WriteLine($"{threeupleTwo.FirstEntry} -> {threeupleTwo.SecondEntry} -> {threeupleTwo.ThirdEntry}");

            input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            Threeuple<string, double, string> threeupleThree = new Threeuple<string, double, string>(input[0], double.Parse(input[1]), input[2]);
            Console.WriteLine($"{threeupleThree.FirstEntry} -> {threeupleThree.SecondEntry} -> {threeupleThree.ThirdEntry}");
        }
    }
}