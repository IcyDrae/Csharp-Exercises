/*
Link: https://leetcode.com/problems/roman-to-integer/description/

Description:

Roman numerals are represented by seven different symbols: I, V, X, L, C, D
and M.

Symbol       Value
I             1
V             5
X             10
L             50
C             100
D             500
M             1000

For example, 2 is written as II in Roman numeral, just two ones added
together. 12 is written as XII, which is simply X + II. The number 27 is
written as XXVII, which is XX + V + II.

Roman numerals are usually written largest to smallest from left to right.
However, the numeral for four is not IIII. Instead, the number four is
written as IV. Because the one is before the five we subtract it making four.
The same principle applies to the number nine, which is written as IX.
There are six instances where subtraction is used:

    I can be placed before V (5) and X (10) to make 4 and 9. 
    X can be placed before L (50) and C (100) to make 40 and 90. 
    C can be placed before D (500) and M (1000) to make 400 and 900.

Given a roman numeral, convert it to an integer.

Example 1:

Input: s = "III"
Output: 3
Explanation: III = 3.

Example 2:

Input: s = "LVIII"
Output: 58
Explanation: L = 50, V= 5, III = 3.

Example 3:

Input: s = "MCMXCIV"
Output: 1994
Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.

Constraints:

    1 <= s.length <= 15
    s contains only the characters ('I', 'V', 'X', 'L', 'C', 'D', 'M').
    It is guaranteed that s is a valid roman numeral in the range [1, 3999].
*/

// Solution
namespace RomanToInteger
{
    public class Solution
    {
/*
Convert a roman numeral to an integer.

Let's map the roman numbers to the normal numbers. Just like in
the description. Loop through the roman numeral, for each value we try to
add or subtract to create an integer.

What if, as in IV(4), the first number of the roman numeral is smaller
than the next number? Check manually if the current number is smaller
than the next, and if so, we subtract the first from the second. And if it's
a numeral with more than two digits, what then? We keep adding to the next
number.
What happens in the case of MCMXCIV(1994)? Here we have a larger first number,
then we have a smaller one than the next one, which means we have to do
operations by pairs. Does that mean two loops so we can get the next number?

No. Loop once, if the current roman number is smaller than the next, subtract
the current number from the next one, and then skip the next character because
it has already been used.
*/
        public int RomanToInt(string s)
        {
            Dictionary<char, int> Mapping = new Dictionary<char, int> {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };
            int Total = 0;
            int Length = s.Length;

            for (int i = 0; i < Length; i++)
            {
                int Current = Mapping[s[i]];
                /* How to get the next element?
                s[i+1]. yes but what if we are currently at the end of
                the string? that means there is no next element. it throws
                an exception. how to get the correct one?
                */
                int Next = 0;

                if ((i + 1) < Length)
                {
                    Next = Mapping[s[i + 1]];
                }

                if (Current < Next)
                {
                    Total = (Total + (Next - Current));
                    /* Skip the next character because we already used it;
                    if we don't do so, it would mistakenly add the next
                    number to the total.
                    */
                    i++;
                }
                else if (Current >= Next)
                {
                    Total = (Current + Total);
                }
            }

            return Total;
        }
    }
}
