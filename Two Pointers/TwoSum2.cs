using System;

namespace NeetCode_150.Two_Pointers;


// Given a 1-indexed array of integers numbers that is already sorted in non-decreasing order, find two numbers such that they add up to a specific target number. Let these two numbers be numbers[index1] and numbers[index2] where 1 <= index1 < index2 <= numbers.length.

// Return the indices of the two numbers, index1 and index2, added by one as an integer array [index1, index2] of length 2.

// The tests are generated such that there is exactly one solution. You may not use the same element twice.

// Your solution must use only constant extra space.



// Example 1:

// Input: numbers = [2,7,11,15], target = 9
// Output: [1,2]
// Explanation: The sum of 2 and 7 is 9. Therefore, index1 = 1, index2 = 2. We return [1, 2].
// Example 2:

// Input: numbers = [2,3,4], target = 6
// Output: [1,3]
// Explanation: The sum of 2 and 4 is 6. Therefore index1 = 1, index2 = 3. We return [1, 3].
// Example 3:

// Input: numbers = [-1,0], target = -1
// Output: [1,2]
// Explanation: The sum of -1 and 0 is -1. Therefore index1 = 1, index2 = 2. We return [1, 2].


// Constraints:

// 2 <= numbers.length <= 3 * 104
// -1000 <= numbers[i] <= 1000
// numbers is sorted in non-decreasing order.
// -1000 <= target <= 1000
// The tests are generated such that there is exactly one solution.
public class TwoSum2
{
    public int[] TwoSum(int[] numbers, int target)
    {
        int left = 0;
        int right = numbers.Length - 1;
        while (left < right)
        {
            if (numbers[left] + numbers[right] == target)
            {
                return new int[] { left + 1, right + 1 };
            }
            if (numbers[left] + numbers[right] < target) //move left if the sum is smaller than target
            {
                left++;
            }
            else                //or move right pointer 
            {
                right--;
            }
        }
        return Array.Empty<int>();
    }

    public int[] TwoSumBinarySearch(int[] numbers, int target)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            int compliment = target - numbers[i];
            int left = i + 1;
            int right = numbers.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (numbers[mid] == compliment)
                {
                    return new int[] { i + 1, mid + 1 };
                }
                else if (numbers[mid] < compliment)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
        }
        return Array.Empty<int>();
    }
}
