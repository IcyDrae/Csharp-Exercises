/*
Link: https://leetcode.com/problems/unique-length-3-palindromic-subsequences/description/

Description:

Given a string s, return the number of unique palindromes of length three
that are a subsequence of s.

Note that even if there are multiple ways to obtain the same subsequence,
it is still only counted once.

A palindrome is a string that reads the same forwards and backwards.

A subsequence of a string is a new string generated from the original
string with some characters (can be none) deleted without changing the
relative order of the remaining characters.

    For example, "ace" is a subsequence of "abcde".

Example 1:

Input: s = "aabca"
Output: 3
Explanation: The 3 palindromic subsequences of length 3 are:
- "aba" (subsequence of "aabca")
- "aaa" (subsequence of "aabca")
- "aca" (subsequence of "aabca")

Example 2:

Input: s = "adc"
Output: 0
Explanation: There are no palindromic subsequences of length 3 in "adc".

Example 3:

Input: s = "bbcbaba"
Output: 4
Explanation: The 4 palindromic subsequences of length 3 are:
- "bbb" (subsequence of "bbcbaba")
- "bcb" (subsequence of "bbcbaba")
- "bab" (subsequence of "bbcbaba")
- "aba" (subsequence of "bbcbaba")

Constraints:

    3 <= s.length <= 105
    s consists of only lowercase English letters.
*/

// Solution
namespace UniqueLength3PalindromicSubsequences
{
    public class Solution
    {
/*
Find subsequences- sequences inside the original, that are in order. The pattern is "xyx", meaning that the
first and last letter must be the same.
This means, for each character "x" in the string, find the indices
where it occurs.
For each such x at the start and end of a subsequence, determine the characters in between.
These are potential candidates for the middle character y.
*/
        // For example: aabca
        public int CountPalindromicSubsequence(string s)
        {
            int Length = s.Length;
            Dictionary<char, List<int>> Occurrences = new Dictionary<char, List<int>>();

            // Populate the occurrences dictionary with distinct values
            for (int i = 0; i < Length; i++)
            {
                // Add a new distinct value only if it doesn't exist
                if (!Occurrences.ContainsKey(s[i]))
                {
                    Occurrences[s[i]] = new List<int>();
                }

                // If it exists, add the new index to the list
                Occurrences[s[i]].Add(i);
            }

            // Process each character group
            HashSet<string> Palindromes = new HashSet<string>();

            foreach (KeyValuePair<char, List<int>> Entry in Occurrences)
            {
                List<int> Indices = Entry.Value;

                // We need at least two character positions(indices) for a valid palindrome
                if (Indices.Count < 2)
                {
                    continue;
                }

                // Get the beginning and the end of the pair
                int First = Indices[0];
                int Last = Indices[Indices.Count - 1];

                // Find unique middle characters
                HashSet<char> MiddleCharacters = new HashSet<char>();

                for (int i = First + 1; i < Last; i++)
                {
                    MiddleCharacters.Add(s[i]);
                }

                // Add unique palindromes to the result
                foreach (char MiddleCharacter in MiddleCharacters)
                {
                    Palindromes.Add($"{Entry.Key}{MiddleCharacter}{Entry.Key}");
                }
            }

            foreach (string Palindrome in Palindromes)
            {
                Console.WriteLine(Palindrome);
            }

            return Palindromes.Count;

/*
Worst-Case time complexity analysis:

Key operations:
1. Populating the `Occurrences` dictionary:
    -> The first `for` loop iterates over the string `s` of length `n`.
    -> Each character is added to a dictionary or its index is appended to a list.
    -> In the worst case, where all characters are distinct, each dictionary operation
      (insertion and retrieval) takes O(1) on average.
    -> Total time complexity for this step: O(n).
2. Iterating over the `Occurrences` dictionary:
    -> The second loop processes each character group. In the worst case, there are 
      26 groups (one for each lowercase English letter).
    -> For each group, it calculates the unique middle characters between the first 
      and last occurrence:
        -> To find the middle characters, we iterate from `First + 1` to `Last - 1`, 
          where the difference between these indices is proportional to `n` in the 
          worst case.
        -> Adding elements to a `HashSet` for unique middle characters takes O(1) 
          on average per insertion.
    -> In the worst case, when each character group spans the entire string:
        -> Extracting the middle characters takes O(n).
        -> This step is repeated for each of the 26 character groups.
    -> Total time complexity for this step: O(26 * n) = O(n), since 26 is a constant.
3. Adding palindromes to the `HashSet`:
    -> For each middle character in the set, a palindrome is constructed and added 
      to a `HashSet`. Each insertion operation takes O(1) on average.
    -> The maximum number of unique palindromes is limited by the total number of 
      character pairs and the middle characters, which is proportional to `n`.
    -> Total time complexity for this step: O(n).
4. Final Count:
    -> Returning the size of the `HashSet` is a constant time operation: O(1).

Overall Time Complexity:
    -> The dominant operation is iterating over the middle characters for each character 
    group, which is O(n) in the worst case.
    -> Since all other operations are either linear or constant with respect to `n`, the 
    overall worst-case time complexity is O(n).
*/
        }
    }
}
