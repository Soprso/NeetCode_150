using System;

namespace NeetCode_150.Arrays___Hashing;

// Problem Statement
// Contains Duplicate
// Given an integer array nums, return true if any value appears more than once in the array, otherwise return false.

// Example 1:

// Input: nums = [1, 2, 3, 3]

// Output: true

// Example 2:

// Input: nums = [1, 2, 3, 4]

// Output: false

// You should aim for a solution with O(n) time and O(n) space, where n is the size of the input array.

public class ContainsDuplicate
{
    public bool hasDuplicate(int[] nums)
    {
        bool hasDuplicateValue = false;
        HashSet<int> set = new HashSet<int>();
        foreach (int i in nums)
        {
            if (!set.Contains(i))
            {
                set.Add(i);
            }
            else
            {
                hasDuplicateValue = true;
            }
        }
        return hasDuplicateValue;
    }
}
