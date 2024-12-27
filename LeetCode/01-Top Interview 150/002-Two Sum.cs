/*
Link: https://leetcode.com/problems/two-sum/description/

Description:

Given an array of integers nums and an integer target, return indices of the
two numbers such that they add up to target.

You may assume that each input would have exactly one solution, and you may
not use the same element twice.

You can return the answer in any order.

Example 1:

Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].

Example 2:

Input: nums = [3,2,4], target = 6
Output: [1,2]

Example 3:

Input: nums = [3,3], target = 6
Output: [0,1]

Constraints:

    2 <= nums.length <= 104
    -109 <= nums[i] <= 109
    -109 <= target <= 109
    Only one valid answer exists.
 
Follow-up: Can you come up with an algorithm that is less than O(n2)
time complexity?
*/

// Solution
namespace TwoSum
{
    public class Solution {
        public int[] TwoSum(int[] nums, int target) {
            // 1. One array of numbers
            // 2. One target
            // 3. Return the positions of the numbers that add up to target
            // 4. Each input has exactly one solution
            // 5. Don't use the same element twice, don't add it to itself
/*
How do I do this? Go through the whole array,
find possible combinations. For example for the input ([2,7,11,15] and 9) we
find 2 in the first position, we keep it, we go through the other elements,
we try every element that can be added to 2 which adds up to 9.

This means we have to find at most all possible combinations of however
many elements there are in the array until we find the second number.
That seems like a lot of work. What if 7 were the last number,
not the second? Our algorithm would have to do all
that work. Is there a more efficient way?
*/

        int FirstElementIndex = -1;
        int SecondElementIndex = -1;

        for (int i = 0; i < nums.Length; i++) {
            for (int j = i + 1; j < nums.Length; j++) {
                if ((nums[i] + nums[j]) == target) {
                        FirstElementIndex = i;
                        SecondElementIndex = j;

                        // Exit inner loop
                        break;
                    }

                    if (FirstElementIndex != -1 && SecondElementIndex != -1) {
                        // Exit the outer loop when a solution is found
                        break;
                    }
                }
            }

            return new int[] {FirstElementIndex, SecondElementIndex};

/*
Worst-Case time complexity analysis:

Key operations:
1. first and second loops, nested loops
    -> compares the nth and n+1th elements if their sum equals
        up to the target(creates pairs)
    -> runs n² times
2. the comparison "(nums[i] + nums[j]) == target"
    -> constant time operation and does not change
    the overall complexity

The Worst-Case complexity is O(n²) because the nested loops run
for all possible direct pairs of elements, which is quadratic
in the size of the array. As n increases, the number of iterations
grows quadratically.
*/
        }
    }
}
