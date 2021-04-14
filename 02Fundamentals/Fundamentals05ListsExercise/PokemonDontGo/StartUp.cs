namespace PokemonDontGo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            List<int> pokeNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int removedSum = 0;
            while (0 < pokeNumbers.Count)
            {
                int index = int.Parse(Console.ReadLine()), removedValue;
                if (index < 0)
                {
                    removedValue = pokeNumbers[0];
                    pokeNumbers.RemoveAt(0);
                    pokeNumbers.Insert(0, pokeNumbers[^1]);
                }
                else if (index >= pokeNumbers.Count)
                {
                    removedValue = pokeNumbers[^1];
                    pokeNumbers.RemoveAt(pokeNumbers.Count - 1);
                    pokeNumbers.Add(pokeNumbers[0]);
                }
                else
                {
                    removedValue = pokeNumbers[index];
                    pokeNumbers.RemoveAt(index);
                }
                removedSum += removedValue;
                for (int i = 0; i < pokeNumbers.Count; i++)
                {
                    if (pokeNumbers[i] > removedValue)
                    {
                        pokeNumbers[i] -= removedValue;
                        continue;
                    }
                    pokeNumbers[i] += removedValue;
                }
            }
            Console.WriteLine(removedSum);
        }
    }
}