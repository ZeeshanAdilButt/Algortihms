using System;

namespace DP_CoinChange
{
    class Program
    {
        static void Main(string[] args)
        {
			int n = 33;
			int[] a = { 25,16,5,1 };

			int[] dp = new int[n + 1];

			Array.Fill(dp, -1);
			dp[0] = 0;

			int ans = minCoins(n, a, dp);
			Console.WriteLine(ans);

			foreach (int x in dp)
			{
				Console.WriteLine(x + " ");
			}
		}

		static int minCoins(int n, int[] a, int[] dp)
		{

			if (n == 0) return 0;

			int ans = int.MaxValue;

			for (int i = 0; i < a.Length; i++)
			{
				if (n - a[i] >= 0)
				{
					int subAns = 0;

					if (dp[n - a[i]] != -1)
					{
						subAns = dp[n - a[i]];
					}
					else
					{
						subAns = minCoins(n - a[i], a, dp);
					}
					if (subAns != int.MaxValue && subAns + 1 < ans)
					{
						ans = subAns + 1;
					}
				}
			}
			return dp[n] = ans;
		}
	}
}
