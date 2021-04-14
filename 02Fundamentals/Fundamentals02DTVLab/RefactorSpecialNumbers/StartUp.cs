namespace RefactorSpecialNumbers
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int obshto = 0, takova;
            bool equivalent;
            for (int ch = 1; ch <= number; ch++)
            {
                takova = ch;
                while (ch > 0)
                {
                    obshto += ch % 10;
                    ch = ch / 10;
                }
                equivalent = (obshto == 5) || (obshto == 7) || (obshto == 11);
                Console.WriteLine("{0} -> {1}", takova, equivalent);
                obshto = 0;
                ch = takova;
            }
        }
    }
}