/*
Link: https://leetcode.com/problems/rotate-array/description/

Description:

Given an integer array nums, rotate the array to the right by k steps,
where k is non-negative.

Example 1:

Input: nums = [1,2,3,4,5,6,7], k = 3
Output: [5,6,7,1,2,3,4]
Explanation:
rotate 1 steps to the right: [7,1,2,3,4,5,6]
rotate 2 steps to the right: [6,7,1,2,3,4,5]
rotate 3 steps to the right: [5,6,7,1,2,3,4]

Example 2:

Input: nums = [-1,-100,3,99], k = 2
Output: [3,99,-1,-100]
Explanation: 
rotate 1 steps to the right: [99,-1,-100,3]
rotate 2 steps to the right: [3,99,-1,-100]

Constraints:

    1 <= nums.length <= 105
    -231 <= nums[i] <= 231 - 1
    0 <= k <= 105

Follow up:

    Try to come up with as many solutions as you can. There are at least
    three different ways to solve this problem.
    Could you do it in-place with O(1) extra space?
*/

// Solution
namespace RotateArray
{
    public class Solution
    {
/*
Begin with the first element in the array. Temporarily store the element
we are about to overwrite.

What if k equals something greater than nums.Length? Then we set k to
k % nums.Length because rotating n times results in the same array.

Calculate the target position of the current element using index+k.
Move the current element to its target location.

Continue to the next position in the cycle until we return to the
starting index.

To ensure all elements are moved, start new cycles from unvisited indices
until all elements are processed.
*/
        // For example: [1,2,3,4,5,6,7]
        public void Rotate(int[] nums, int k)
        {
            // Optimize k to handle cases where k >= n
            int K = (k % nums.Length);
            // Track number of moved elements
            int Count = 0;

            // Loop through starting indices, but stop once all elements
            // have been moved
            for (int i = 0; Count < nums.Length; i++)
            {
                // Set the current index to the starting index of the cycle
                int Current = i;
                // Store the value at the starting index
                int PreviousValue = nums[i];

                do
                {
                    // Calculate the target index for the current element
                    int Next = (Current + k) % nums.Length;
                    // Temporarily store the value at the target index
                    int Temporary = nums[Next];

                    // Move the value from the previous index to the target index
                    nums[Next] = PreviousValue;
                    // Update PreviousValue to the value that was at the target index
                    PreviousValue = Temporary;

                    // Move to the next index in the cycle
                    Current = Next;
                    // Increment the counter, as we've moved one more element
                    Count++;

                // Continue the cycle until we return to the starting index
                } while (i != Current);
            }

            // Print the array to the console
            foreach (int num in nums)
            {
                Console.WriteLine(num);
            }

/*
Worst-Case time complexity analysis:

Key operations:
1. Outer for loop
    -> Runs from the first element to the end of "nums"
    -> Each iteration begins a new cycle to move elements
    -> The for loop ensures that all elements are visited, so the total
    number of iterations across all cycles is n, the size of the array.
2. Inner while loop
    -> The inner loop handles a single cycle of movements. For a cycle
        starting at index i, it continues until the element at the current
        position returns to its original position.
    -> The number of iterations for the inner loop is equal to the size of
        the cycle, and all cycles together cover all n elements of the array.
3. Element swaps
    -> Each element is moved exactly once. Therefore, the total number of
        swaps or updates is proportional to n, regardless of the number
        of cycles.

Since each element is processed exactly once during the entire operation,
the overall time complexity is O(n), where n is the length of the array.
*/
        }
    }
}
