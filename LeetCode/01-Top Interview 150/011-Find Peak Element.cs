/*
Link: https://leetcode.com/problems/find-peak-element/description/

Description:

A peak element is an element that is strictly greater than its neighbors.

Given a 0-indexed integer array nums, find a peak element, and return its
index. If the array contains multiple peaks, return the index to any of the
peaks.

You may imagine that nums[-1] = nums[n] = -∞. In other words, an element is
always considered to be strictly greater than a neighbor that is outside the
array.

You must write an algorithm that runs in O(log n) time.

Example 1:

Input: nums = [1,2,3,1]
Output: 2
Explanation: 3 is a peak element and your function should return the index
number 2.

Example 2:

Input: nums = [1,2,1,3,5,6,4]
Output: 5
Explanation: Your function can return either index number 1 where the peak
element is 2, or index number 5 where the peak element is 6.

Constraints:

    1 <= nums.length <= 1000
    -231 <= nums[i] <= 231 - 1
    nums[i] != nums[i + 1] for all valid i.
*/

// Solution
namespace PeakElement
{
    public class Solution
    {
/*
We need two pointers, one for the beginning, one for the end of the array.
Calculate the middle.
Check if the middle is larger or not than the next element, depending on that
go to the right or the left of the array.
Compare the current element to its preceding and following neighbour, and if
it's larger than both of them, it's the peak.
Compare the middle if its larger than the preceding and the following
neighbour, then it's the peak.
*/
        // For example: [1,2,3,1]
        public int FindPeakElement(int[] nums)
        {
            // Initialize pointers
            int BeginningPointer = 0;
            int EndPointer = (nums.Length - 1);
            int MiddlePointer;

            /* Iterate from the beginning till the end, while also taking
            from the end and decrementing it.
            */
            while (BeginningPointer < EndPointer)
            {
                // Calculate the middle pointer
                MiddlePointer = (BeginningPointer + EndPointer) / 2;
                int MiddleElement = nums[MiddlePointer];
                int Next = nums[MiddlePointer + 1];

                // If the middle element is smaller than the next element,
                // go right
                if (MiddleElement < Next)
                {
                    BeginningPointer = MiddlePointer + 1;
                }
                // If the middle element is larger than the next, go left
                else if (MiddleElement > Next)
                {
                    EndPointer = MiddlePointer;
                }
            }

            // At the end, when beginning = end, this must be the peak
            return BeginningPointer;

/*
Worst-Case time complexity analysis:

Key operations:
1. Binary search loop
    -> Runs from the first element and the last one towards the middle
        of "nums"
    -> Each iteration halves the running space by constantly finding the
        middle
    -> The total number of iterations is (log2 * n).
2. Element comparison
    -> During each iteration the algorithm compares the middle element to
        the next one to decide which half of the array to explore next
    -> This is a constant-time operation.

The total time complexity is O(log n).
*/
        }
    }
}
