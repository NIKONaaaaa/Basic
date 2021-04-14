namespace PokeMon
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int pokePower = int.Parse(Console.ReadLine()), pokeDistance = int.Parse(Console.ReadLine()), pokeExhaustion = int.Parse(Console.ReadLine()), pokeAmount = 0, pokeCurrentPower = pokePower;
            while (pokeDistance <= pokeCurrentPower)
            {
                pokeCurrentPower -= pokeDistance;
                pokeAmount++;
                if (pokeCurrentPower * 2 == pokePower && pokeExhaustion != 0)
                {
                    pokeCurrentPower /= pokeExhaustion;
                }
            }
            Console.WriteLine(pokeCurrentPower);
            Console.WriteLine(pokeAmount);
        }
    }
}