/*
Link: https://leetcode.com/problems/number-of-ways-to-split-array/description/

Description:

You are given a 0-indexed integer array nums of length n.

nums contains a valid split at index i if the following are true:

    The sum of the first i + 1 elements is greater than or equal to the sum
    of the last n - i - 1 elements.
    There is at least one element to the right of i. That is, 0 <= i < n - 1.

Return the number of valid splits in nums.

Example 1:

Input: nums = [10,4,-8,7]
Output: 2
Explanation:
There are three ways of splitting nums into two non-empty parts:
- Split nums at index 0. Then, the first part is [10], and its sum is 10.
    The second part is [4,-8,7], and its sum is 3. Since 10 >= 3, i = 0
    is a valid split.
- Split nums at index 1. Then, the first part is [10,4], and its sum is 14.
    The second part is [-8,7], and its sum is -1. Since 14 >= -1, i = 1
    is a valid split.
- Split nums at index 2. Then, the first part is [10,4,-8], and its sum is 6.
    The second part is [7], and its sum is 7. Since 6 < 7, i = 2 is not a
    valid split.
Thus, the number of valid splits in nums is 2.

Example 2:

Input: nums = [2,3,1,0]
Output: 2
Explanation:
There are two valid splits in nums:
- Split nums at index 1. Then, the first part is [2,3],
    and its sum is 5. The second part is [1,0], and its sum is 1.
    Since 5 >= 1, i = 1 is a valid split. 
- Split nums at index 2. Then, the first part is [2,3,1],
    and its sum is 6. The second part is [0], and its sum is 0.
    Since 6 >= 0, i = 2 is a valid split.
*/

// Solution
namespace NumberOfWaysToSplitArray
{
    public class Solution
    {
/*
1. Left sum must be greater than or equals right sum
2. Index i is not the last one

Beginning Pointer incrementing. End Pointer not decrementing.

Sum of all elements from 0 until BeginningPointer >= sum of
EndPointer until BeginningPointer + 1.

How do I get the sum of all numbers until the index? Second inner loop? Damn it.
Get the total sum first. That's a linear time loop. Then get the running sum
of the left side. Then subtract the running left sum from the total sum to get
the right sum. That saves us quite a lot of time.
*/
        // For example: [10,4,-8,7]
        public int WaysToSplitArray(int[] nums)
        {
            int BeginningPointer;
            int EndPointer = (nums.Length - 1);
            long SumLeft = 0;
            long SumRight = 0;
            long TotalSum = 0;
            int SplitAmount = 0;

            // Get the total sum
            for (BeginningPointer = 0;
                BeginningPointer <= EndPointer;
                BeginningPointer++)
            {
                TotalSum = TotalSum + nums[BeginningPointer];
            }

            // This is where the actual work is done
            for (BeginningPointer = 0;
                BeginningPointer < EndPointer;
                BeginningPointer++)
            {
                // Get the running sum until now
                SumLeft = SumLeft + nums[BeginningPointer];
                // Get the right sum
                SumRight = TotalSum - SumLeft;

                // Compare the two and increment the amount of the valid
                // splits
                if (SumLeft >= SumRight)
                {
                    SplitAmount++;
                }
            }

            return SplitAmount;

/*
Worst-Case time complexity analysis:

Key operations:
1. First for loop
    -> Runs from the first element until the end of "nums"
    -> Adds all numbers together and gets us the total.
    -> The total number of iterations is n where n is the length of the array.
2. Second for loop
    -> Calculates the left sum starting from the 0th index until the outer index
    called 'BeginningPointer'. That is the left side of the array.
    -> This is a linear time operation and it takes O(n) time.
4. Constant time operations
    -> Comparing the left sum with the right sum, initializing and updating
        variables takes constant time.

The total time complexity is O(n) because we traverse the array at most
once at a time.
*/
        }
    }
}
