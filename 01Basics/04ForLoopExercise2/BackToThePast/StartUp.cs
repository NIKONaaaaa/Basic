namespace BackToThePast
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            double moneyInheritance = double.Parse(Console.ReadLine());
            int currentAge = 17;
            int survivalYear = int.Parse(Console.ReadLine());
            for (int i = 1800; i <= survivalYear; i++)
            {
                currentAge++;
                if (i % 2 == 0)
                {
                    moneyInheritance -= 12000;
                }
                else
                {
                    moneyInheritance -= 12000 + 50 * currentAge;
                }
            }
            if (moneyInheritance >= 0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {moneyInheritance:f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {Math.Abs(moneyInheritance):f2} dollars to survive.");
            }
        }
    }
}