namespace ASCIISumator
{
    using System;
    class StartUp
    {
        static void Main()
        {
            char start = char.Parse(Console.ReadLine()), end = char.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int sum = 0;
            foreach (char ch in input)
            {
                if (Math.Min(start, end) < ch && ch < Math.Max(start, end))
                {
                    sum += ch;
                }
            }
            Console.WriteLine(sum);
        }
    }
}