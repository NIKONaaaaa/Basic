namespace BirthdayParty
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double rent = double.Parse(Console.ReadLine());
            double cakePrice = rent * 0.2;
            double drinksPrice = cakePrice * 0.55;
            double animator = rent * 1 / 3;
            double sum = rent + cakePrice + drinksPrice + animator;
            Console.WriteLine(sum);
        }
    }
}