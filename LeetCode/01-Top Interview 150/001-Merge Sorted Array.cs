/*
Link: https://leetcode.com/problems/merge-sorted-array/description/

Description:

You are given two integer arrays nums1 and nums2, sorted in non-decreasing
order, and two integers m and n, representing the number of elements in
nums1 and nums2 respectively.

Merge nums1 and nums2 into a single array sorted in non-decreasing order.

The final sorted array should not be returned by the function, but instead
be stored inside the array nums1. To accommodate this, nums1 has a length
of m + n, where the first m elements denote the elements that should be
merged, and the last n elements are set to 0 and should be ignored.
nums2 has a length of n.

Example 1:

Input: nums1 = [1,2,3,0,0,0], m = 3, nums2 = [2,5,6], n = 3
Output: [1,2,2,3,5,6]
Explanation: The arrays we are merging are [1,2,3] and [2,5,6].
The result of the merge is [1,2,2,3,5,6] with the underlined elements coming
from nums1.

Example 2:

Input: nums1 = [1], m = 1, nums2 = [], n = 0
Output: [1]
Explanation: The arrays we are merging are [1] and [].
The result of the merge is [1].

Example 3:

Input: nums1 = [0], m = 0, nums2 = [1], n = 1
Output: [1]
Explanation: The arrays we are merging are [] and [1].
The result of the merge is [1].
Note that because m = 0, there are no elements in nums1. The 0 is only
there to ensure the merge result can fit in nums1.

Constraints:

    nums1.length == m + n
    nums2.length == n
    0 <= m, n <= 200
    1 <= m + n <= 200
    -109 <= nums1[i], nums2[j] <= 109

Follow up: Can you come up with an algorithm that runs in O(m + n) time?
*/

// Solution
namespace MergeSortedArray
{
    public class Solution {
        public void Merge(int[] nums1, int m, int[] nums2, int n) {
            // 1. 0s should be ignored
            // 2. Merge and sort at the same time;
            // in non-decreasing order, every element
            // is equals to or greater than the one before it
            
            int Nums1Pointer = m - 1;
            int Nums2Pointer = n - 1;
            int FinalNums1Pointer = m + n - 1;

            while (Nums1Pointer >= 0 && Nums2Pointer >= 0) {
                if (nums1[Nums1Pointer] > nums2[Nums2Pointer]) {
                    nums1[FinalNums1Pointer--] = nums1[Nums1Pointer--];
                } else {
                    nums1[FinalNums1Pointer--] = nums2[Nums2Pointer--];
                }
            }

            while (Nums2Pointer >= 0) {
                nums1[FinalNums1Pointer--] = nums2[Nums2Pointer--];
            }

            /*
            Worst-Case time complexity analysis:

            Key operations:
            1. first while loop
                -> compares and moves elements froms nums1 and nums2 into
                their correct positions
                -> runs n+m times for n=Nums1Pointer and m=Nums2Pointer
            2. second while loop
                -> moves remaining elements from nums2 into nums1
                -> runs n times for n=Nums2Pointer

            The Worst-Case complexity is O(n+m) because all elements
            from both arrays are processed exactly once across both loops.
            */

            // Output
            foreach (int num in nums1) {
                Console.WriteLine(num);
            }
        }
    }
}
