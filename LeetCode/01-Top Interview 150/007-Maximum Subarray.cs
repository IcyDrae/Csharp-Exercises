/*
Link: https://leetcode.com/problems/maximum-subarray/description/

Description:

Given an integer array nums, find the subarray
with the largest sum, and return its sum.

Example 1:

Input: nums = [-2,1,-3,4,-1,2,1,-5,4]
Output: 6
Explanation: The subarray [4,-1,2,1] has the largest sum 6.

Example 2:

Input: nums = [1]
Output: 1
Explanation: The subarray [1] has the largest sum 1.

Example 3:

Input: nums = [5,4,-1,7,8]
Output: 23
Explanation: The subarray [5,4,-1,7,8] has the largest sum 23.

Constraints:

    1 <= nums.length <= 105
    -104 <= nums[i] <= 104

Follow up: If you have figured out the O(n) solution, try coding another
solution using the divide and conquer approach, which is more subtle.
*/

// Solution
namespace MaximumSubarray
{
    public class Solution
    {
/*
A subarray is any continuous segment of the original array.

We need to keep track of the current sum of a potential subarray and of
the maximum sum encountered so far, so we can compare them and find out the
largest sum at the end of the array.

Loop through the array, have a sum placeholder which will be added to as the
array is traversed. Start adding continuous numbers to each other.
How to know how many numbers should be added together? 2 or 3 or 4?
That means we would try every possible subarray which is n!(factorial), which
is a lot of steps and not performant at all.

How to take a dynamic decision?

Each step of the loop we should ask ourselves: "Should we include this
number in the current subarray, or should we start a new subarray beginning
with the next number?" But how do we take that decision?
It depends on whether the current number increases or decreases the total
sum of the subarray so far.
*/
        // For example: [-2,1,-3,4,-1,2,1,-5,4]
        public int MaxSubArray(int[] nums)
        {
            // Keep track of the maximum sum encountered until now
            int MaximumSum = nums[0];
            // Keep track of the current sum of the current subarray
            int CurrentSum = nums[0];

            // Loop through the array of integers
            for (int i = 1; i < nums.Length; i++)
            {
                // Keep track of the current number
                int CurrentNumber = nums[i];

                // If adding the current number increases the sum
                if ((CurrentSum + CurrentNumber) > CurrentNumber)
                {
                    // Add to the current sum
                    CurrentSum = (CurrentSum + CurrentNumber);
                }
                // If it decreases it,
                // start a new subarray from the next number
                else
                {
                    CurrentSum = CurrentNumber;
                }

                // Add to the maximum sum only if it increases thereby
                if (MaximumSum < CurrentSum)
                {
                    MaximumSum = CurrentSum;
                }
            }

            return MaximumSum;
/*
Worst-Case time complexity analysis:

Key operations:
1. The for loop
    -> Runs from the second element to the end of "nums"
    -> For a string of length n, the loop runs at most n times.
2. The for loop contains constant time operations. Comparing if the current
    number increases the sum or not, and checking if the current subarray
    sum is larger than the maximum sum.

The Worst-Case complexity is O(n).
*/
        }
    }
}
