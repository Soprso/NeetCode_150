using System;

namespace NeetCode_150.Two_Pointers;

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
