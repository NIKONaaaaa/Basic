namespace SmallestOfThreeNumbers
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int numberOne = int.Parse(Console.ReadLine()), numberTwo = int.Parse(Console.ReadLine()), numberThree = int.Parse(Console.ReadLine());
            Console.WriteLine(MinNumber(numberOne, numberTwo, numberThree));
            static int MinNumber(int a, int b, int c)
            {
                int[] numbers = { a, b, c };
                Array.Sort(numbers);
                return numbers[0];
            }
        }
    }
}