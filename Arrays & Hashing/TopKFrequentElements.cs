using System;

namespace NeetCode_150.Arrays___Hashing;

// 347. Top K Frequent Elements
// Medium
// Topics
// premium lock icon
// Companies
// Given an integer array nums and an integer k, return the k most frequent elements. You may return the answer in any order.

 

// Example 1:

// Input: nums = [1,1,1,2,2,3], k = 2
// Output: [1,2]
// Example 2:

// Input: nums = [1], k = 1
// Output: [1]
 

// Constraints:

// 1 <= nums.length <= 105
// -104 <= nums[i] <= 104
// k is in the range [1, the number of unique elements in the array].
// It is guaranteed that the answer is unique.
 

// Follow up: Your algorithm's time complexity must be better than O(n log n), where n is the array's size.
public class TopKFrequentElements
{
    public int[] TopFreq(int[] nums, int k)
    {
        Dictionary<int, int> freqCtr = new Dictionary<int, int>();

        //count frequency
        foreach (int i in nums)
        {
            if (freqCtr.ContainsKey(i))
            {
                freqCtr[i]++;
            }
            else
            {
                freqCtr[i] = 1;
            }
        }

        //this is where LINQ comes in hand
        var topK = freqCtr.OrderByDescending(pair => pair.Value) //sorts the dictionary entries by frequency(value) in descending order
        .Take(k)    //takes only the first K items from the sorted result
        .Select(pair => pair.Key)   //taking only keys from key-value pair
        .ToArray(); //convert to array to return.

        return topK;
    }
}
