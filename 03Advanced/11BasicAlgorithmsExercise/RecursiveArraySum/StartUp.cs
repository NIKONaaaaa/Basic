namespace RecursiveArraySum
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Console.WriteLine(SumElements(array, array.Length - 1));
        }
        public static int SumElements(int[] array, int index)
        {
            if (index == 0)
            {
                return array[index];
            }
            array[index - 1] += array[index];
            return SumElements(array, index - 1);
        }
    }
}