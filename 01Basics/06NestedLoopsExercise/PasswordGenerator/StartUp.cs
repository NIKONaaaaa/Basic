namespace PasswordGenerator
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int numberInput = int.Parse(Console.ReadLine());
            int letterInput = int.Parse(Console.ReadLine());
            for (int counterOne = 1; counterOne < numberInput; counterOne++)
            {
                for (int counterTwo = 1; counterTwo < numberInput; counterTwo++)
                {
                    for (int counterThree = 'a'; counterThree < 'a' + letterInput; counterThree++)
                    {
                        for (int counterFour = 'a'; counterFour < 'a' + letterInput; counterFour++)
                        {
                            for (int counterFive = Math.Max(counterOne, counterTwo) + 1; counterFive <= numberInput; counterFive++)
                            {
                                Console.Write($"{counterOne}{counterTwo}{(char)counterThree}{(char)counterFour}{counterFive} ");
                            }
                        }
                    }
                }
            }
        }
    }
}