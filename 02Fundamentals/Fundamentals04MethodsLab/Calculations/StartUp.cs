namespace Calculations
{
    using System;
    class StartUp
    {
        static void Main()
        {
            string command = Console.ReadLine();
            int numOne = int.Parse(Console.ReadLine()), numTwo = int.Parse(Console.ReadLine());
            if (command == "add") Add(numOne, numTwo);
            else if (command == "multiply") Multiply(numOne, numTwo);
            else if (command == "subtract") Subtract(numOne, numTwo);
            else Divide(numOne, numTwo);
            static void Add(int numOne, int numTwo)
            {
                Console.WriteLine(numOne + numTwo);
            }
            static void Multiply(int numOne, int numTwo)
            {
                Console.WriteLine(numOne * numTwo);
            }
            static void Subtract(int numOne, int numTwo)
            {
                Console.WriteLine(numOne - numTwo);
            }
            static void Divide(int numOne, int numTwo)
            {
                Console.WriteLine(numOne / numTwo);
            }
        }
    }
}