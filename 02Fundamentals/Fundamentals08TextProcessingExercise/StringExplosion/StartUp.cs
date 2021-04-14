namespace StringExplosion
{
    using System;
    class StartUp
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int explosionStrength = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (explosionStrength != 0)
                {
                    if (input[i] != '>')
                    {
                        input = input.Remove(i, 1);
                        explosionStrength--;
                        i--;
                    }
                    else
                    {
                        explosionStrength += int.Parse(input[i + 1].ToString());
                    }
                }
                else if (input[i] == '>')
                {
                    explosionStrength = int.Parse(input[i + 1].ToString());
                }
            }
            Console.WriteLine(input);
        }
    }
}