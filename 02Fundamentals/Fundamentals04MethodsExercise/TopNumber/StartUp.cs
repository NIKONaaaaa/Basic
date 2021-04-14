namespace TopNumber
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            TopNumberCheck(int.Parse(Console.ReadLine()));
            static void TopNumberCheck(int a)
            {
                for (int i = 1; i < a; i++)
                {
                    string lengthCheck = i.ToString();
                    int[] digits = new int[lengthCheck.Length];
                    bool check = false;
                    int number = i;
                    int counter = 0;
                    while (0 < number)
                    {
                        digits[counter] = number % 10;
                        if (digits[counter] % 2 != 0)
                        {
                            check = true;
                        }
                        number = number / 10;
                        counter++;
                    }
                    if (digits.Sum() % 8 == 0 && check)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}