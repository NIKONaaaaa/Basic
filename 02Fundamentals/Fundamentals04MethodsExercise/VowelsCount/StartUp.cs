namespace VowelsCount
{
    using System;
    class StartUp
    {
        static void Main()
        {
            Console.WriteLine(VowelCount(Console.ReadLine().ToLower()));
            static int VowelCount(string input)
            {
                string vowels = "aeiou";
                int counter = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    for (int j = 0; j < vowels.Length; j++)
                    {
                        if (input[i] == vowels[j])
                        {
                            counter++;
                            break;
                        }
                    }
                }
                return counter;
            }
        }
    }
}