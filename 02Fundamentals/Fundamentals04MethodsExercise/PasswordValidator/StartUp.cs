namespace PasswordValidator
{
    using System;
    class StartUp
    {
        static void Main()
        {
            string password = Console.ReadLine();
            bool checkLength = LengthCheck(password), checkLetterDigit = LetterDigitCheck(password), checkTwoDigits = TwoDigitsCheck(password);
            if (checkLength && checkLetterDigit && checkTwoDigits)
            {
                Console.WriteLine("Password is valid");
            }
            static bool LengthCheck(string password)
            {
                bool check = true;
                if (6 > password.Length || password.Length > 10)
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                    check = false;
                }
                return check;
            }
            static bool LetterDigitCheck(string password)
            {
                bool check = true;
                for (int i = 0; i < password.Length; i++)
                {
                    if ((48 > (int)password[i] || (int)password[i] > 57) && (65 > (int)password[i] || (int)password[i] > 90) && (97 > (int)password[i] || (int)password[i] > 122))
                    {
                        Console.WriteLine("Password must consist only of letters and digits");
                        check = false;
                        break;
                    }
                }
                return check;
            }
            static bool TwoDigitsCheck(string password)
            {
                bool check = true;
                int digitCount = 0;
                for (int i = 0; i < password.Length; i++)
                {
                    if (48 <= password[i] && password[i] <= 57)
                    {
                        digitCount++;
                    }
                }
                if (digitCount < 2)
                {
                    Console.WriteLine("Password must have at least 2 digits");
                    check = false;
                }
                return check;
            }
        }
    }
}