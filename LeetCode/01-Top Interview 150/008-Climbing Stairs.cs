/*
Link: https://leetcode.com/problems/climbing-stairs/description/

Description:

You are climbing a staircase. It takes n steps to reach the top.

Each time you can either climb 1 or 2 steps. In how many distinct ways can
you climb to the top?

Example 1:

Input: n = 2
Output: 2
Explanation: There are two ways to climb to the top.
1. 1 step + 1 step
2. 2 steps

Example 2:

Input: n = 3
Output: 3
Explanation: There are three ways to climb to the top.
1. 1 step + 1 step + 1 step
2. 1 step + 2 steps
3. 2 steps + 1 step

Constraints:

    1 <= n <= 45
*/

// Solution
namespace ClimbingStairs
{
    public class Solution
    {
/*
We need to find out the possible amount of combinations of 1 and 2
that sum up to the number of stairs.
So, basically how many times do we have to sum 1 and 2 together so we can get
the number of stairs.

How do we do that?

If we are at step n, we could have come from step n−1
(by taking a single step) or from step n−2 (by taking two steps).
Therefore, the formula is: ways(n) = ways(n−1) + ways(n−2)
*/
        // For example: 3
        public int ClimbStairs(int n)
        {
            // Base cases, for 1 and 2
            if (n == 1)
            {
                return 1;
            }

            if (n == 2)
            {
                return 2;
            }

            // Create an array to store the ways, which is the true size of
            // n
            int[] Ways = new int[n + 1];
            // One way to reach the first step
            Ways[1] = 1;
            // Two ways to reach the second step
            Ways[2] = 2;

            for (int i = 3; i <= n; i++)
            {
                Ways[i] = Ways[i - 1] + Ways[i - 2];
            }

            return Ways[n];
        }
    }
}
