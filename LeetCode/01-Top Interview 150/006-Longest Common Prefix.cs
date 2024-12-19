/*
Link: https://leetcode.com/problems/longest-common-prefix/description/

Description:

Write a function to find the longest common prefix string amongst an array
of strings.

If there is no common prefix, return an empty string "".

Example 1:

Input: strs = ["flower","flow","flight"]
Output: "fl"

Example 2:

Input: strs = ["dog","racecar","car"]
Output: ""
Explanation: There is no common prefix among the input strings.

Constraints:

    1 <= strs.length <= 200
    0 <= strs[i].length <= 200
    strs[i] consists of only lowercase English letters.
*/

// Solution
namespace LongestCommonPrefix
{
    public class Solution
    {
/*
We get an array of multiple strings which we assume are words in the English
language. Find the longest common prefix, which means the longest beginning
of a word that comes up in all of those words.

How to do this? First of all we need to check if all words start with the same
letter or letters. This means we have to check from the beginning of the string,
not any other position. But how to compare two strings together?
Letter by letter?
We need to stop comparing if any one of the words which is not the last one
does not begin with that prefix.

The main condition is that all words need to have that prefix.
We need to keep track of the prefix as we find out what it is.
What if we manually set the prefix to the first whole word and incrementally,
for each other word, check if the letters correspond? If they don't, reduce
the prefix by one letter from the end and then check again with the new
prefix.
*/
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0) {
                return "";
            }

            // The first word is the prefix
            string Prefix = strs[0];

            // Loop through all the words, starting from the second one
            for (int i = 1; i < strs.Length; i++)
            {
                // Check if the current word does not start with the prefix
                while (!strs[i].StartsWith(Prefix)) {
                    // Shorten the prefix by one at a time
                    Prefix = Prefix.Substring(0, Prefix.Length - 1);

                    // If the prefix becomes empty, there is no common prefix
                    if (Prefix == "") {
                        return "";
                    }
                }
            }

            return Prefix;
        }
    }
}
