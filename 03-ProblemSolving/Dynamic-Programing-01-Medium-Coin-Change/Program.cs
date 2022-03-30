using System;

namespace Dynamic_Programing_01_Medium_Coin_Change
{
    /* We have input values of N and
an array Coins that holds all of
the coins. We use data type of
long because we want to be able
to test large values without
integer overflow*/
    using System;

    public class getWays
    {

        static long getNumberOfWays(long N, long[] Coins)
        {
            // Create the ways array to 1 plus the amount
            // to stop overflow
            long[] ways = new long[(int)N + 1];

            // Set the first way to 1 because its 0 and
            // there is 1 way to make 0 with 0 coins
            ways[0] = 1;

            // Go through all of the coins
            for (int coinIndex = 0; coinIndex < Coins.Length; coinIndex++)
            {

                long currentCoin = Coins[coinIndex];

                // Make a comparison to each index value
                // of ways with the coin value.
                for (int totalAmount = 0; totalAmount < ways.Length; totalAmount++)
                {
                    if (currentCoin <= totalAmount)
                    {
                        // Update the ways array
                        ways[totalAmount] += ways[(int)(totalAmount - currentCoin)];
                    }
                }
            }

            // return the value at the Nth position
            // of the ways array.
            return ways[(int)N];
        }

        static void printArray(int[] coins)
        {
            foreach (int i in coins)
                Console.WriteLine(i);
        }

        public static int changeDynamic2(int totalAmount, int[] coins)
        {
            int[] dp = new int[totalAmount + 1];

            for (int i = 1; i < totalAmount; i++) { dp[i] = int.MaxValue; }

            dp[0] = 0;

            for (int currentAmount = 1; currentAmount < dp.Length; currentAmount++)
            {
                foreach (var coin in coins)
                {
                    if (currentAmount - coin >= 0)
                    {
                        dp[currentAmount] = Math.Min(dp[currentAmount], dp[currentAmount- coin]) + 1;
                    }
                }
            }
            return dp[totalAmount];
        }

        public static int changeDynamic(int totalAmount, int[] coins)
        {
            int[] cache = new int[totalAmount];
            for (int i = 1; i < totalAmount; i++) { cache[i] = -1; }

            return changeDynamic(totalAmount, coins, cache);
        }

        public static int changeDynamic(int totalAmount, int[] coins, int[] cache)
        {
            if (totalAmount == 0) return 0;

            int min = totalAmount;

            for (int coinIndex = 0; coinIndex < coins.Length; coinIndex++)
            {
                var coin = coins[coinIndex];

                if (totalAmount - coin >= 0)
                {
                    int change;

                    //if the current coin can be used , use the value of previous index
                    if (cache[totalAmount - coin] >= 0)
                        change = cache[totalAmount - coin];
                    //else substract amount and call change dynamic on remaining amount
                    else
                    {
                        change = changeDynamic(totalAmount - coin, coins, cache);
                        cache[totalAmount - coin] = change;
                    }
                    if (min > change + 1)
                        min = change + 1;
                }
            }
            return min;
        }

        // Driver code
        public static void Main(String[] args)
        {
            int[] Coins = { 10, 1, 2, 5};

            //Console.WriteLine("The Coins Array:");
            //printArray(Coins);

            Console.WriteLine("Solution:");
            Console.WriteLine(changeDynamic2(12, Coins));
        }
    }

    // This code has been contributed by 29AjayKumar

}
