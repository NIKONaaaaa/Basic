namespace EncryptSortAndPrintArray
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int arrayLength = int.Parse(Console.ReadLine());
            string vowels = "AaEeIiOoUu";
            int[] arrayEncoded = new int[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                string input = Console.ReadLine();
                for (int j = 0; j < input.Length; j++)
                {
                    char currentLetter = input[j];
                    if (vowels.Contains(currentLetter))
                    {
                        arrayEncoded[i] += currentLetter * input.Length;
                    }
                    else
                    {
                        arrayEncoded[i] += currentLetter / input.Length;
                    }
                }
            }
            Array.Sort(arrayEncoded);
            for (int i = 0; i < arrayLength; i++)
            {
                Console.WriteLine(arrayEncoded[i]);
            }
        }
    }
}