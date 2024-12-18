/*
Link: https://leetcode.com/problems/valid-anagram/description/

Description:

Given two strings s and t, return true if t is an anagram of s, and false
otherwise.

An anagram is a word or phrase formed by rearranging the letters of a
different word or phrase, using all the original letters exactly once.

Example 1:

Input: s = "anagram", t = "nagaram"

Output: true

Example 2:

Input: s = "rat", t = "car"

Output: false

Constraints:

    1 <= s.length, t.length <= 5 * 104
    s and t consist of lowercase English letters.

Follow up: What if the inputs contain Unicode characters? How would you
adapt your solution to such a case?
*/

// Solution
namespace ValidAnagram
{
    public class Solution {
/*
This means we have to find out if 't' contains all the letters of 's', each
one exactly once, in any order.

How to solve this?

First approach: Check if both strings are of the same length.
Loop through 's', inside which, loop through 't' and prove if each letter
from s is equals to each letter of 't', in no particular order,
and keep track of all the letters
that are equal to track out progress. This seems a very long process.

Second approach: What if we sort both strings alphabetically and then if
they both the same?

Third approach: As we loop through both strings one by one,
keep track of how many times each characters comes up. If each character
of both strings comes up an equal amount of times, then 't' must be an
anagram of 's'.
*/
        public bool IsAnagram(string s, string t) {
            // Second approach
            // char[] CharactersS = s.ToArray();
            // char[] CharactersT = t.ToArray();
            // Array.Sort(CharactersS);
            // Array.Sort(CharactersT);
            // string NewS = new string(CharactersS);
            // string NewT = new string(CharactersT);

            // return NewS == NewT;

            // Third approach
            // Create a variable to store the frequency count for each
            // letter of the alphabet. If we subtract chars from each other,
            // their ASCII values would be subtracted,
            // that will give us the position of the letter based on the
            // beginning of the alphabet.
            int[] Frequency = new int[26];

            // Loop through both strings separately and keep track of each
            // letter's frequency. Increment the frequency for each char
            // of 's' and decrement the frequency for each char of 't'.
            // If, in the end of both loops, each position in the frequency
            // is 0, that means both strings are equal(in an unsorted way)

            for (int i = 0; i < s.Length; i++) {
                Frequency[s[i] - 'a']++;
            }

            for (int i = 0; i < t.Length; i++) {
                Frequency[t[i] - 'a']--;
            }

            for (int i = 0; i < Frequency.Length; i++) {
                if (Frequency[i] != 0) {
                    return false;
                }
            }

            return true;
        }
    }
}
