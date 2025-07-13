using System;
using System.Globalization;

namespace NeetCode_150.Arrays___Hashing;


// 242. Valid Anagram
// Easy
// Topics
// premium lock icon
// Companies
// Given two strings s and t, return true if t is an anagram of s, and false otherwise.



// Example 1:

// Input: s = "anagram", t = "nagaram"

// Output: true

// Example 2:

// Input: s = "rat", t = "car"

// Output: false



// Constraints:

// 1 <= s.length, t.length <= 5 * 104
// s and t consist of lowercase English letters.

public class ValidAnagram
{
    public bool IsAnagram(string s, string t)
    {
        char[] chforS = s.ToCharArray();
        char[] chforT = t.ToCharArray();
        //now there are two ways to check anagram, one in sorting the array, and the other way is to count the frequency using Dictionary.
        //Dictionary Way
        Dictionary<char, int> sDict = new Dictionary<char, int>(); //store char as key and their frequency as values for string s
        //count each character in s
        foreach (char c in chforS)
        {
            if (sDict.ContainsKey(c))
            {
                sDict[c]++;
            }
            else
            {
                sDict[c] = 1;
            }
        }

        if (s.Length == t.Length)
        {
            foreach (char c in t)
            {
                if (!sDict.ContainsKey(c))
                {
                    return false;
                }
                sDict[c]--;
                if (sDict[c] == 0)
                {
                    sDict.Remove(c);
                }
            }
        }
        return sDict.Count == 0;
    }

    public bool IsAnagramSort(string s, string t)
    {
        if (s.Length != t.Length)
            return false;
        char[] ch = BubbleStringSort(s.ToCharArray());
        char[] ch2 = BubbleStringSort(t.ToCharArray());


        return ch.SequenceEqual(ch2);

    }

    public char[] BubbleStringSort(char[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - 1 - i; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    char temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
        return arr;
    }
}
