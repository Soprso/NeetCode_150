using System;

namespace NeetCode_150.Two_Pointers;

// Given n non-negative integers representing an elevation map where the width of each bar is 1, compute how much water it can trap after raining.

 

// Example 1:


// Input: height = [0,1,0,2,1,0,1,3,2,1,2,1]
// Output: 6
// Explanation: The above elevation map (black section) is represented by array [0,1,0,2,1,0,1,3,2,1,2,1]. In this case, 6 units of rain water (blue section) are being trapped.
// Example 2:

// Input: height = [4,2,0,3,2,5]
// Output: 9
 

// Constraints:

// n == height.length
// 1 <= n <= 2 * 104
// 0 <= height[i] <= 105
public class TrappingRainWater
{
    public int Trap(int[] height)
    {
        //two pointer approach
        int left = 0;
        int right = height.Length - 1;
        int leftMax = 0;
        int rightMax = 0;
        int total = 0;
        while (left < right)
        {
            if (height[left] < height[right])
            {
                leftMax = Math.Max(leftMax, height[left]);
                if (leftMax - height[left] > 0)
                {
                    total += leftMax - height[left];
                }
                left++;
            }
            else
            {
                rightMax = Math.Max(rightMax, height[right]);
                if (rightMax - height[right] > 0)
                {
                    total += rightMax - height[right];
                }
                right--;
            }
        }
        return total;
    }
}
