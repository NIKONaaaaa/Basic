namespace VowelsSum
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            int vowelSum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char letter = input[i];
                switch (letter)
                {
                    case 'a':
                        vowelSum++;
                        break;
                    case 'e':
                        vowelSum += 2;
                        break;
                    case 'i':
                        vowelSum += 3;
                        break;
                    case 'o':
                        vowelSum += 4;
                        break;
                    case 'u':
                        vowelSum += 5;
                        break;
                    default:
                        vowelSum += 0;
                        break;
                }
            }
            Console.WriteLine(vowelSum);
        }
    }
}