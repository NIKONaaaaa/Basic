namespace KaminoFactory
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            int lengthDNA = int.Parse(Console.ReadLine());
            int[] DNA = new int[lengthDNA];
            int length = 0, index = 0, sum = 0, currentRow = 0, row = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Clone them!")
                {
                    break;
                }
                int[] currentDNA = input.Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                currentRow++;
                int currentSum = 0;
                for (int i = 0; i < currentDNA.Length; i++)
                {
                    if (currentDNA[i] == 1)
                    {
                        currentSum++;
                    }
                }
                int currentLength = 0;
                int currentIndex = 0;
                for (int i = 0; i < currentDNA.Length; i++)
                {
                    if (currentDNA[i] == 1)
                    {
                        currentLength++;
                        if (currentLength == 1)
                        {
                            currentIndex = i;
                        }
                        if (currentLength > length || currentLength == length && (currentIndex < index || currentSum > sum))
                        {
                            length = currentLength;
                            index = currentIndex;
                            row = currentRow;
                            DNA = currentDNA;
                            sum = currentSum;
                        }
                    }
                    else
                    {
                        currentIndex = 0;
                        currentLength = 0;
                    }
                }
            }
            if (row == 0)
            {
                row = 1;
            }
            Console.WriteLine($"Best DNA sample {row} with sum: {sum}.");
            Console.WriteLine(string.Join(" ", DNA));
        }
    }
}