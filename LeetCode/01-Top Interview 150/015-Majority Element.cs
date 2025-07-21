/*
Link: https://leetcode.com/problems/majority-element/description/

Description:

Given an array nums of size n, return the majority element.

The majority element is the element that appears more than ⌊n / 2⌋ times.
You may assume that the majority element always exists in the array.

Example 1:

Input: nums = [3,2,3]
Output: 3

Example 2:

Input: nums = [2,2,1,1,1,2,2]
Output: 2

Constraints:

    n == nums.length
    1 <= n <= 5 * 104
    -109 <= nums[i] <= 109
 
Follow-up: Could you solve the problem in linear time and in O(1) space?
*/

// Solution
namespace MajorityElement
{
    public class Solution
    {
/*
Find the number that appears more than half the time. For example,
in an array of 7 elements, the majority element must appear at least 4 times.
Counter variable -> Candidate variable -> Loop -> Keep track of candidate
and count how many times it comes up, otherwise decrement the counter
variable because the current element is not the same as the candidate.
*/
        // For example: Input: nums = [3,2,3]
        // Output: 3
        public int MajorityElement(int[] nums)
        {
            int Candidate = 0;
            int Counter = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (Counter == 0)
                {
                    Candidate = nums[i]; // pick a new candidate
                }

                if (nums[i] == Candidate)
                {
                    Counter++; // same as candidate, increase count
                } else
                {
                    Counter--; // different from candidate, cancel out
                }
            }

            return Candidate;

/*
Worst-Case time complexity analysis:

Key operations:
1. For loop
    -> Runs once from index 0 to the end of "nums"
    -> Each iteration does constant-time operations (comparisons, assignments)
    -> The total number of iterations is n

The total time complexity is O(n)
The space complexity is O(1), since only two variables are used
*/
        }
    }
}
