namespace CleverLily
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washerPrice = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());
            int birthdayMoney = 9;
            double savings = 0;
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    savings += birthdayMoney;
                    birthdayMoney += 10;
                }
                else
                {
                    savings += toyPrice;
                }
            }
            if (washerPrice <= savings)
            {
                Console.WriteLine($"Yes! {savings - washerPrice:f2}");
            }
            else
            {
                Console.WriteLine($"No! {washerPrice - savings:f2}");
            }
        }
    }
}