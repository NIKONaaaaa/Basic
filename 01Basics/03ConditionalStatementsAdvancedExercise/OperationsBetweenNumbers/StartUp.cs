namespace OperationsBetweenNumbers
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            double numberOne = double.Parse(Console.ReadLine());
            double numberTwo = double.Parse(Console.ReadLine());
            string operationType = Console.ReadLine();
            string evenCheck = "even";
            if (((operationType == "+" && (numberOne + numberTwo) % 2 != 0)) || ((operationType == "-" && (numberOne - numberTwo) % 2 != 0)) || ((operationType == "*" && (numberOne * numberTwo) % 2 != 0)))
            {
                evenCheck = "odd";
            }
            if (numberTwo == 0 && (operationType == "/" || operationType == "%"))
            {
                Console.WriteLine($"Cannot divide {numberOne} by zero");
            }
            else
            {
                switch (operationType)
                {
                    case "+":
                        Console.WriteLine($"{numberOne} {operationType} {numberTwo} = {numberOne + numberTwo} - {evenCheck}");
                        break;
                    case "-":
                        Console.WriteLine($"{numberOne} {operationType} {numberTwo} = {numberOne - numberTwo} - {evenCheck}");
                        break;
                    case "*":
                        Console.WriteLine($"{numberOne} {operationType} {numberTwo} = {numberOne * numberTwo} - {evenCheck}");
                        break;
                    case "/":
                        Console.WriteLine($"{numberOne} {operationType} {numberTwo} = {numberOne / numberTwo:f2}");
                        break;
                    case "%":
                        Console.WriteLine($"{numberOne} {operationType} {numberTwo} = {numberOne % numberTwo}");
                        break;
                }
            }
        }
    }
}