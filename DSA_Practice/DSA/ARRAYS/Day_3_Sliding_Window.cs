// What is Sliding Window?
// Sliding Window is a technique used to:
// Reduce nested loops
// Convert O(n²) → O(n)
// Work on contiguous subarrays / substrings
// Instead of recomputing every subarray,
// we expand and shrink a window.


// Types of Sliding Window
// A) Fixed Size Window
// Window size = K (constant)
// Example:
// Maximum sum of subarray of size K
// Pattern:
// First compute first K elements
// Then slide:
// Add next element
// Remove first element
// Time → O(n)

// question 1. Maximum Sum Subarray of Size K
// Problem Statement:
// You are given an array of integers and an integer K. Your task is to find the maximum possible sum of any contiguous subarray of size exactly K. A contiguous subarray consists of elements that are next to each other in the original array.
// Input:
// Array = [2, 1, 5, 1, 3, 2]
// K = 3
// Output:
// 9

// using System;
// class MaxSumSubarraySizeK
// {
//     static void Main()
//     {
//         int[] arr = { 2, 1, 5, 1, 3, 2 };
//         int K = 3;
//         int n = arr.Length;
//         if (n < K)
//         {
//             Console.WriteLine("Invalid Input");
//             return;
//         }
//         // Step 1: Calculate first window sum
//         int windowSum = 0;
//         for (int i = 0; i < K; i++)
//         {
//             windowSum += arr[i];
//         }
//         int maxSum = windowSum;
//         // Step 2: Slide the window
//         for (int i = K; i < n; i++)
//         {
//             windowSum += arr[i];       // Add next element
//             windowSum -= arr[i - K];   // Remove previous window start
//             maxSum = Math.Max(maxSum, windowSum);
//         }
//         Console.WriteLine("Maximum Sum = " + maxSum);
//     }
// }



// Quesrion 2. First Negative Number in Every Window of Size K
// Problem Statement:
// You are given an array of integers that may contain both positive and negative values. For every contiguous subarray (window) of size K, find the first negative integer in that window. If a particular window does not contain any negative integer, output 0 for that window.
// Input:
// Array = [12, -1, -7, 8, -15, 30, 16, 28]
// K = 3
// Output:
// [-1, -1, -7, -15, -15, 0]

// using System;
// using System.Collections.Generic;
// class FirstNegativeInWindow
// {
//     static void Main()
//     {
//         int[] arr = { 12, -1, -7, 8, -15, 30, 16, 28 };
//         int K = 3;
//         int n = arr.Length;
//         Queue<int> negatives = new Queue<int>();
//         List<int> result = new List<int>();
//         int left = 0;
//         for (int right = 0; right < n; right++)
//         {
//             // Step 1: If current element is negative, add to queue
//             if (arr[right] < 0)
//             {
//                 negatives.Enqueue(arr[right]);
//             }
//             // Step 2: When window size becomes K
//             if (right - left + 1 == K)
//             {
//                 // If queue not empty → first negative is at front
//                 if (negatives.Count > 0)
//                     result.Add(negatives.Peek());
//                 else
//                     result.Add(0);
//                 // Step 3: Before sliding, remove element going out
//                 if (negatives.Count > 0 && arr[left] == negatives.Peek())
//                 {
//                     negatives.Dequeue();
//                 }
//                 left++;
//             }
//         }

//         Console.WriteLine("Output: [" + string.Join(", ", result) + "]");
//     }
// }


// using System;
// class FirstNegativeWithoutQueue
// {
//     static void Main()
//     {
//         int[] arr = { 12, -1, -7, 8, -15, 30, 16, 28 };
//         int K = 3;
//         int n = arr.Length;
//         Console.Write("Output: [");
//         for (int i = 0; i <= n - K; i++)
//         {
//             int firstNegative = 0;
//             // Check elements inside current window
//             for (int j = i; j < i + K; j++)
//             {
//                 if (arr[j] < 0)
//                 {
//                     firstNegative = arr[j];
//                     break;  // Stop at first negative
//                 }
//             }
//             Console.Write(firstNegative);
//             if (i < n - K)
//                 Console.Write(", ");
//         }
//         Console.WriteLine("]");
//     }
// }

// Count Subarrays of Size K with Sum Equal to X
// Problem Statement:
// You are given an array of integers, an integer K, and a target value X. Count the number of contiguous subarrays of size exactly K whose elements add up to X.
// Input:
// Array = [1, 2, 3, 1, 1, 1, 1]
// K = 3
// X = 6
// Output:
// 2

// B) Variable Size Window
// Window grows and shrinks dynamically
// Used when:
// Condition based problems
// Sum <= K
// Unique characters
// At most K distinct
// Two pointers:
// left, right