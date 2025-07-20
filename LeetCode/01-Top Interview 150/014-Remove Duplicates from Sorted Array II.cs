/*
Link: https://leetcode.com/problems/remove-duplicates-from-sorted-array-ii/description/

Description:

Given an integer array nums sorted in non-decreasing order, remove some
duplicates in-place such that each unique element appears at most twice.
The relative order of the elements should be kept the same.

Since it is impossible to change the length of the array in some languages,
you must instead have the result be placed in the first part of the array
nums. More formally, if there are k elements after removing the duplicates,
then the first k elements of nums should hold the final result.
It does not matter what you leave beyond the first k elements.

Return k after placing the final result in the first k slots of nums.

Do not allocate extra space for another array. You must do this by modifying
the input array in-place with O(1) extra memory.

Custom Judge:

The judge will test your solution with the following code:

int[] nums = [...]; // Input array
int[] expectedNums = [...]; // The expected answer with correct length

int k = removeDuplicates(nums); // Calls your implementation

assert k == expectedNums.length;
for (int i = 0; i < k; i++) {
    assert nums[i] == expectedNums[i];
}

If all assertions pass, then your solution will be accepted.

Example 1:

Input: nums = [1,1,1,2,2,3]
Output: 5, nums = [1,1,2,2,3,_]
Explanation: Your function should return k = 5, with the first five elements of nums being 1, 1, 2, 2 and 3 respectively.
It does not matter what you leave beyond the returned k (hence they are underscores).

Example 2:

Input: nums = [0,0,1,1,1,1,2,3,3]
Output: 7, nums = [0,0,1,1,2,3,3,_,_]
Explanation: Your function should return k = 7, with the first seven elements of nums being 0, 0, 1, 1, 2, 3 and 3 respectively.
It does not matter what you leave beyond the returned k (hence they are underscores).

Constraints:

    1 <= nums.length <= 3 * 104
    -104 <= nums[i] <= 104
    nums is sorted in non-decreasing order.
*/

// Solution
namespace RemoveDuplicatesII
{
    public class Solution
    {
/*
We are only allowed 2 duplicates max. Any further duplicate must be removed.
Count the remaining elements in the array after removing the further
duplicates.
*/
        // For example: Input: nums = [0,0,1,1,1,1,2,3,3]
        // Output: 7, nums = [0,0,1,1,2,3,3,_,_]
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length <= 2)
            {
                return nums.Length;
            }

            int i = 2; // Keep track of where to write the next valid number

            for (int j = 2; j < nums.Length; j++)
            {
                /*
                If the current number is not the same as the number two
                spots back, it’s allowed.
                */
                if (nums[j] != nums[i - 2])
                {
                    nums[i] = nums[j]; // write the number to position i
                    i++; // move the write pointer
                }
            }

            return i;
/*
Worst-Case time complexity analysis:

Key operations:
1. For loop
    -> Runs from the third element (index 2) until the end of "nums"
    -> Each iteration compares nums[j] with nums[i - 2] — a constant time
    operation
    -> If elements are different, we overwrite nums[i] — also constant time
    -> The total number of iterations is (n - 2), which is proportional
    to the size of the array

The total time complexity is O(n)
*/
        }
    }
}
