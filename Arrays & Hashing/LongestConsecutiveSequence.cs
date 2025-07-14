using System;

namespace NeetCode_150.Arrays___Hashing;

public class LongestConsecutiveSequence
{
    public int LongestConsecutive(int[] nums)
    {
        if (nums.Length == 0) return 0;
        Array.Sort(nums);
        int longestCommonSub = 1;
        int currentSub = 1;
        for (int i = 1; i < nums.Length; i++)  //[-1,-1,0,0,2,3,4,5,7,200]
        {


            if (nums[i] - nums[i - 1] == 1)
            {
                currentSub++;
            }
            else if (nums[i] == nums[i - 1])
            {
                continue; //skip dupes
            }
            else 
            {
                longestCommonSub = Math.Max(longestCommonSub, currentSub);
                currentSub = 1;
            }
        }
        return  Math.Max(longestCommonSub, currentSub);
    }
}
