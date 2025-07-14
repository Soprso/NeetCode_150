using System;

namespace NeetCode_150.Two_Pointers;
// Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.

// Notice that the solution set must not contain duplicate triplets.

 

// Example 1:

// Input: nums = [-1,0,1,2,-1,-4]
// Output: [[-1,-1,2],[-1,0,1]]
// Explanation: 
// nums[0] + nums[1] + nums[2] = (-1) + 0 + 1 = 0.
// nums[1] + nums[2] + nums[4] = 0 + 1 + (-1) = 0.
// nums[0] + nums[3] + nums[4] = (-1) + 2 + (-1) = 0.
// The distinct triplets are [-1,0,1] and [-1,-1,2].
// Notice that the order of the output and the order of the triplets does not matter.
// Example 2:

// Input: nums = [0,1,1]
// Output: []
// Explanation: The only possible triplet does not sum up to 0.
// Example 3:

// Input: nums = [0,0,0]
// Output: [[0,0,0]]
// Explanation: The only possible triplet sums up to 0.
 

// Constraints:

// 3 <= nums.length <= 3000
// -105 <= nums[i] <= 105
public class ThreeSumProblem
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        //using hashset
        //sort the array
        Array.Sort(nums);
        List<IList<int>> result = new List<IList<int>>();
        for (int i = 0; i < nums.Length - 2; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1])
            {
                continue; //skip dupes for nums[i]
            }
            HashSet<int> seen = new HashSet<int>();
            for (int j = i + 1; j < nums.Length; j++)
            {
                int compliment = -nums[i] - nums[j];
                if (seen.Contains(compliment))
                {
                    result.Add(new List<int> { nums[i], nums[j], compliment });
                    while (j + 1 < nums.Length && nums[j] == nums[j + 1]) //skip dupes for nums[j]
                        j++;
                }
                seen.Add(nums[j]);
            }

        }
        return result;
    }
}
