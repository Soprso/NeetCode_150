using System;
using System.Globalization;

namespace NeetCode_150.Sliding_Window;
// 🪟 What is a Sliding Window?
// A Sliding Window is a subrange (or "window") that moves through an array or string to check conditions over a subset of elements — like a frame that "slides" one step at a time.

// Think of it like a real window that slides left or right across the array.

// 🔄 How It Works:
// Imagine this array:

// ini
// Copy
// Edit
// nums = [1, 3, 2, 5, 1, 1, 2]
// And suppose you want to find the maximum sum of any 3 consecutive elements.

// Brute Force:
// Check every subarray of size 3

// Time: O(n * k)

// ✅ Sliding Window:
// Use a window of size 3

// Slide it one step at a time, updating the sum in O(1) time

// Step-by-step:
// Start with the first window: 1 + 3 + 2 = 6

// Slide forward:

// Subtract 1 (left element)

// Add 5 (new right element)

// New sum: 6 - 1 + 5 = 10

// Repeat until the end

// This reduces the time from O(n * k) to O(n)
public class SlidingWindowTutorial
{
    public int SumKConsecutive(int[] arr, int k) //k is the window length
    {
        int windowSum = 0;
        int maxSum = 0;
        for (int i = 0; i < k; i++)
        {
            windowSum += arr[i];
        }
        maxSum = windowSum;
        for (int i = k; i < arr.Length; i++)
        {
            windowSum += arr[i] - arr[i - k]; //Add the new element that just entered the window (arr[i])
                                              //Subtract the element that just left the window (arr[i - k])
            maxSum = Math.Max(windowSum, maxSum);
        }
        return maxSum;
    }


    //the above is an example of a fixed sliding window.

    // | Variant                   | When to Use                                                          |
    // | ------------------------- | -------------------------------------------------------------------- |
    // | Fixed-size window         | When you’re looking for things like **max sum of size `k`**          |
    // | Dynamic-size window       | When the window **expands and shrinks**, like for substrings         |
    // | Two-pointer (start & end) | For problems like **Longest Substring Without Repeating Characters** |

    // 🧠 Common Problems Using Sliding Window:
    // ✅ Maximum Subarray of Size k

    // ✅ Longest Substring Without Repeating Characters

    // ✅ Minimum Size Subarray Sum

    // ✅ Permutation in String

    // ✅ Max Consecutive Ones

    // ✅ Fruits Into Baskets


}