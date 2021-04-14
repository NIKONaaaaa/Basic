using System;
using System.Collections.Generic;
using System.Linq;
public class SumOfCoins
{
    public static void Main()
    {
        List<int> availableCoins = new List<int> { 1, 2, 5, 10, 20, 50 };
        long targetSum = 923;
        try
        {
            Dictionary<int, long> selectedCoins = ChooseCoins(availableCoins, targetSum);
            Console.WriteLine($"Number of coins to take: {selectedCoins.Values.Sum()}");
            foreach (KeyValuePair<int, long> selectedCoin in selectedCoins.Where(coinAmount => coinAmount.Value > 0))
            {
                Console.WriteLine($"{selectedCoin.Value} coin(s) with value {selectedCoin.Key}");
            }
        }
        catch (Exception error)
        {
            Console.WriteLine(error.Message);
        }
    }
    public static Dictionary<int, long> ChooseCoins(IList<int> coins, long targetSum)
    {
        Dictionary<int, long> selectedCoins = new Dictionary<int, long>();
        coins = coins.OrderByDescending(value => value).ToList();
        int i = 0;
        while (0 < targetSum && i < coins.Count)
        {
            long coinCount = targetSum / coins[i];
            targetSum %= coins[i];
            selectedCoins.Add(coins[i], coinCount);
            i++;
        }
        if (0 < targetSum)
        {
            throw new Exception("Error");
        }
        return selectedCoins;
    }
}