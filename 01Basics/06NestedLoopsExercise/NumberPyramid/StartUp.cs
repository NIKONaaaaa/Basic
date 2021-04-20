namespace NumberPyramid
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int numberCurrent = 1;
            bool check = false;
            for (int row = 1; row <= number; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    if (number < numberCurrent)
                    {
                        check = true;
                        break;
                    }
                    Console.Write(numberCurrent + " ");
                    numberCurrent++;
                }
                if (check)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}