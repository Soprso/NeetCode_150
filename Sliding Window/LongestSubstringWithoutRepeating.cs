using System;

namespace NeetCode_150.Sliding_Window;


// Given a string s, find the length of the longest substring without duplicate characters.

 

// Example 1:

// Input: s = "abcabcbb"
// Output: 3
// Explanation: The answer is "abc", with the length of 3.
// Example 2:

// Input: s = "bbbbb"
// Output: 1
// Explanation: The answer is "b", with the length of 1.
// Example 3:

// Input: s = "pwwkew"
// Output: 3
// Explanation: The answer is "wke", with the length of 3.
// Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.
 

// Constraints:

// 0 <= s.length <= 5 * 104
// s consists of English letters, digits, symbols and spaces.
public class LongestSubstringWithoutRepeating
{
    public int LengthOfLongestSubstring(string s)
    {
        int maxLength = 0;
        int left = 0;
        // int right = s.Length - 1;
        // int currentLength = 0;
        HashSet<char> set = new HashSet<char>();
        char[] ch = s.ToCharArray();
        for (int right = 0; right < s.Length; right++)
        {
            while (set.Contains(s[right]))
            {
                set.Remove(s[left]);
                left++;
            }
            set.Add(s[right]);
            maxLength = Math.Max(maxLength,right-left+1);
        }
        return maxLength;
    }
}
