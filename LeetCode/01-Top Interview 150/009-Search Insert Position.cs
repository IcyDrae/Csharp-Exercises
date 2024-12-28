/*
Link: https://leetcode.com/problems/search-insert-position/description/

Description:

Given a sorted array of distinct integers and a target value, return the
index if the target is found. If not, return the index where it would be
if it were inserted in order.

You must write an algorithm with O(log n) runtime complexity.

Example 1:

Input: nums = [1,3,5,6], target = 5
Output: 2

Example 2:

Input: nums = [1,3,5,6], target = 2
Output: 1

Example 3:

Input: nums = [1,3,5,6], target = 7
Output: 4

Constraints:

    1 <= nums.length <= 104
    -104 <= nums[i] <= 104
    nums contains distinct values sorted in ascending order.
    -104 <= target <= 104
*/

// Solution
namespace SearchInsertPosition
{
    public class Solution
    {
/*
Return the index of the target element in the sorted array. If the target
does not exist in the array, return the index of it as if it were part of
the sorted array.

Required complexity is O(logn). That means we have to repeatedly halve the
array. If we repeatedly halve the array how do we find the target element?
How do we find out the middle of the array so that we know which half to use
in order to find the target in?

Use two pointers, one for the beginning and one for the end of the array.
Find the middle index using them. Compare the element in the middle with
the target.

If the number in the middle equals target, we already found it, return the
index, which is the middle index.
If the number in the middle is smaller than the target, the target is located
in the right half. Adjust the beginning pointer to mid + 1.
If the number in the middle is larger than the target, the target is located
in the left half. Adjust the end pointer to mid - 1.
If the beginning pointer is larger than the end pointer, the target is not
located in the array. At this point, the beginning pointer represents the
index where the target would be inserted while maintaining the array's sorted
order.
*/
        // For example: [1,3,5,6]
        public int SearchInsert(int[] nums, int target)
        {
            // Initialize pointer
            int BeginningPointer = 0;
            int EndPointer = (nums.Length - 1);
            int MiddlePointer;

            // Run the loop until we are at the middle, respectfully
            // until the beginning pointer is equals to the end pointer
            while (BeginningPointer <= EndPointer)
            {
                // Calculate the middle of the array
                MiddlePointer = (BeginningPointer + EndPointer) / 2;

                // If the middle of the array is the target,
                // return the middle pointer
                if (nums[MiddlePointer] == target)
                {
                    return MiddlePointer;
                }
                // If the element at the middle index is smaller than the
                // target, set the beginning pointer to the first element
                // after the middle. This is also where the target would end
                // up if it's not located in the array.
                else if (nums[MiddlePointer] < target)
                {
                    BeginningPointer = MiddlePointer + 1;
                }
                // If the element at the middle index is larger than the
                // target, set the end pointer to the first element
                // before the middle
                else
                {
                    EndPointer = MiddlePointer - 1;
                }
            }

            // Return the position where the target would have been
            return BeginningPointer;

/*
Worst-Case time complexity analysis:

Key operations:
1. The while loop
    -> Runs from the first element to the end of "nums" using a pointer
    -> The loop iteratively narrows the search range by halving the size
        of the array in each iteration.
    -> For an array of size n, the loop runs at most log2(n) times, because
        the array is halved in each iteration.
2. The for loop contains constant time operations such as comparing
    the middle element to the target.

The total time complexity is drived by the number of iterations of the
    while loop. Since the array is halved at each step
    the worst-case time complexity is O(log n).
*/
        }
    }
}
