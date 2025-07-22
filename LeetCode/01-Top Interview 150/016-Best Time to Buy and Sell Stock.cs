/*
Link: https://leetcode.com/problems/best-time-to-buy-and-sell-stock/description/

Description:

You are given an array prices where prices[i] is the price of a given stock
on the ith day.

You want to maximize your profit by choosing a single day to buy one stock
and choosing a different day in the future to sell that stock.

Return the maximum profit you can achieve from this transaction.
If you cannot achieve any profit, return 0.

Example 1:

Input: prices = [7,1,5,3,6,4]
Output: 5
Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
Note that buying on day 2 and selling on day 1 is not allowed
because you must buy before you sell.

Example 2:

Input: prices = [7,6,4,3,1]
Output: 0
Explanation: In this case, no transactions are done and the max profit = 0.

Constraints:

    1 <= prices.length <= 105
    0 <= prices[i] <= 104
*/

// Solution
namespace MaxProfit
{
    public class Solution
    {
/*
Loop -> Ask yourself, what's the lowest price I've seen so far? ->
If I sell today how much profit would I make? ->
Is that better than my best profit so far? -> Two variables.
*/
        // Input: prices = [7,1,5,3,6,4]
        // Output: 5
        public int MaxProfit(int[] prices)
        {
            int MaxProfit = 0;
            int LowestPrice = prices[0]; // The first price is the lowest yet

            for (int i = 0; i < prices.Length; i++) // From beginning to end
            {
                // Check if we have found a new lowest price and update
                // the lowest price variable
                if (prices[i] < LowestPrice)
                {
                    LowestPrice = prices[i];
                }
                else // If not, then
                {
                    // Check if we have a profit and save it temporary
                    int TemporaryProfit = prices[i] - LowestPrice;

                    // If the current profit is greater than the current max
                    // profit, update the max profit
                    if (TemporaryProfit > MaxProfit)
                    {
                        MaxProfit = TemporaryProfit;
                    }
                }
            }

            return MaxProfit; // Always return max profit

/*
Worst-Case time complexity analysis:

Key operations:
1. For loop
    -> Runs once from index 0 to the end of "prices"
    -> Each iteration does constant-time operations (comparisons, assignments)
    -> The total number of iterations is n

The total time complexity is O(n)
The space complexity is O(1), since only three variables are used
*/
        }
    }
}
