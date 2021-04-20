namespace MultiplyBy2
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            double numOne = double.Parse(Console.ReadLine());
            while (0 <= numOne)
            {
                Console.WriteLine($"Result: {numOne * 2:f2}");
                numOne = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Negative number!");
        }
    }
}