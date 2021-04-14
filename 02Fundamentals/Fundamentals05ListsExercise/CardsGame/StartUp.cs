namespace CardsGame
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            List<int> playerOneHand = Console.ReadLine().Split().Select(int.Parse).ToList(), playerTwoHand = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (0 < playerOneHand.Count && 0 < playerTwoHand.Count)
            {
                if (playerOneHand[0] > playerTwoHand[0])
                {
                    playerOneHand.Add(playerOneHand[0]);
                    playerOneHand.Add(playerTwoHand[0]);
                }
                else if (playerOneHand[0] < playerTwoHand[0])
                {
                    playerTwoHand.Add(playerTwoHand[0]);
                    playerTwoHand.Add(playerOneHand[0]);
                }
                playerOneHand.RemoveAt(0);
                playerTwoHand.RemoveAt(0);
            }
            if (playerOneHand.Count == 0)
            {
                Console.WriteLine($"Second player wins! Sum: {playerTwoHand.Sum()}");
            }
            else
            {
                Console.WriteLine($"First player wins! Sum: {playerOneHand.Sum()}");
            }
        }
    }
}