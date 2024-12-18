/*
Link: https://leetcode.com/problems/palindrome-number/description/

Description:

Given an integer x, return true if x is a palindrome, and false otherwise.

Example 1:

Input: x = 121
Output: true
Explanation: 121 reads as 121 from left to right and from right to left.

Example 2:

Input: x = -121
Output: false
Explanation: From left to right, it reads -121. From right to left, it
becomes 121-. Therefore it is not a palindrome.

Example 3:

Input: x = 10
Output: false
Explanation: Reads 01 from right to left. Therefore it is not a palindrome. 

Constraints:

    -231 <= x <= 231 - 1
 
Follow up: Could you solve it without converting the integer to a string?
*/

// Solution
namespace PalindromeNumber
{
    public class Solution {
        public bool IsPalindrome(int x) {
/*
In the case of a two digit number such as 22, split the number in two parts
and prove whether both numbers are the same.

In the case of three digit numbers such as 121, split the number in three
parts and prove whether the first number is the same as the last.

If the three digit number is a negative number such as -121,
take the minus as a substring as well and prove whether the first character
(minus) equals the last character. It doesn't.

In the case of a four digit number such as 1221, split the number in four
parts and prove that the first number equals the last, and the second number
equals the third.

What if we reverse the number and then prove if it is equals the original one?
That seems like an extra responsibility for the algorithm.
*/
            string Number = x.ToString();
            // The beginning of the string
            int Left;
            // The end of the string
            int Right = Number.Length - 1;

            // Loop until left and right are the same, or
            // where they meet each other, meaning the middle number
            for (Left = 0; Left < Right; Left++, Right--) {
                if (Number[Left] != Number[Right]) {
                    return false;
                }
            }

            return true;
        }
    }
}
