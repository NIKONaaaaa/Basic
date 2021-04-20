namespace OddEvenPosition
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            double oddSum = 0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            double evenSum = 0;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;
            if (counter > 0)
            {
                for (int i = 1; i <= counter; i++)
                {
                    double number = double.Parse(Console.ReadLine());
                    if (i % 2 != 0)
                    {
                        oddSum += number;
                        if (number >= oddMax)
                        {
                            oddMax = number;
                        }
                        if (number <= oddMin)
                        {
                            oddMin = number;
                        }
                    }
                    else
                    {
                        evenSum += number;
                        {
                            if (number >= evenMax)
                            {
                                evenMax = number;
                            }
                            if (number <= evenMin)
                            {
                                evenMin = number;
                            }
                        }
                    }
                }
            }
            Console.WriteLine($"OddSum={oddSum:f2},");
            if (counter > 0)
            {
                Console.WriteLine($"OddMin={oddMin:f2},");
                Console.WriteLine($"OddMax={oddMax:f2},");
            }
            else
            {
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
            }
            Console.WriteLine($"EvenSum={evenSum:f2},");
            if (counter > 1)
            {
                Console.WriteLine($"EvenMin={evenMin:f2},");
                Console.WriteLine($"EvenMax={evenMax:f2}");
            }
            else
            {
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
        }
    }
}