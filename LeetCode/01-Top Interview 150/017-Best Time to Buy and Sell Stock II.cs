/*
Link: https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii/description/
*/

// Solution
namespace MaxProfitII
{
    public class Solution
    {
/*
Task: maximize total profit.
*/
        // Input: prices = [7,1,5,3,6,4]
        // Output: 7
        public int MaxProfit(int[] prices)
        {
            int MaxProfit = 0;

            // Start at the second day since we compare with the previous day
            for (int i = 1; i < prices.Length; i++)
            {
                // If today's price is higher than yesterday's, we can profit
                if (prices[i] > prices[i - 1])
                {
                    // Add the profit we would make from buying
                    // yesterday and selling today
                    MaxProfit += prices[i] - prices[i - 1];
                }
            }

            return MaxProfit;

/*
Worst-Case time complexity analysis:

Key operations:
1. For loop
    -> Runs once from index 1 to the end of "prices"
    -> Each iteration does constant-time operations (comparison and addition)
    -> The total number of iterations is (n - 1), which is still O(n)

The total time complexity is O(n)
The space complexity is O(1), since only one variable is used
*/
        }
    }
}
