using System;

namespace NeetCode_150.Arrays___Hashing;


// 49. Group Anagrams
// Medium
// Topics
// premium lock icon
// Companies
// Given an array of strings strs, group the anagrams together. You can return the answer in any order.



// Example 1:

// Input: strs = ["eat","tea","tan","ate","nat","bat"]

// Output: [["bat"],["nat","tan"],["ate","eat","tea"]]

// Explanation:

// There is no string in strs that can be rearranged to form "bat".
// The strings "nat" and "tan" are anagrams as they can be rearranged to form each other.
// The strings "ate", "eat", and "tea" are anagrams as they can be rearranged to form each other.
// Example 2:

// Input: strs = [""]

// Output: [[""]]

// Example 3:

// Input: strs = ["a"]

// Output: [["a"]]



// Constraints:

// 1 <= strs.length <= 104
// 0 <= strs[i].length <= 100
// strs[i] consists of lowercase English letters.
public class GroupAnagrams
{
    public IList<IList<string>> groupAnagrams(string[] strs)
    {
        Dictionary<string, List<string>> group_map = new Dictionary<string, List<string>>();

        foreach (string s in strs)
        {
            string map_key = BubbleStringSort(s); // sortstring to use as key
            if (!group_map.ContainsKey(map_key))
            {
                group_map[map_key] = new List<string>();
            }
            group_map[map_key].Add(s);
        }
        // Convert Dictionary values to IList<IList<string>> and return
        return group_map.Values.ToList<IList<string>>();
    }

    public string BubbleStringSort(string s)
    {
        char[] arr = s.ToCharArray(); 
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
        return string.Join("",arr);
    }
}
