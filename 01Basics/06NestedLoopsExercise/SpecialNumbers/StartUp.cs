namespace SpecialNumbers
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int numberInput = int.Parse(Console.ReadLine());
            for (int number = 1111; number <= 9999; number++)
            {
                {
                    int digitOne = number / 1000;
                    int digitTwo = (number % 1000) / 100;
                    int digitThree = (number % 100) / 10;
                    int digitFour = (number % 10);
                    if (digitTwo != 0 && digitThree != 0 && digitFour != 0)
                    {
                        if (numberInput % digitOne == 0 && numberInput % digitTwo == 0 && numberInput % digitThree == 0 && numberInput % digitFour == 0)
                        {
                            Console.Write(number + " ");
                        }
                    }
                }
            }
        }
    }
}