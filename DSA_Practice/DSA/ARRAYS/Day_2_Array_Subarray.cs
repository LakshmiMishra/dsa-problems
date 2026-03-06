//   printng subarray using three loops

// using System;
// class PrintAllSubarrays
// {
//     static void Main()
//     {
//         int[] arr = { 10, 20, 30, 40 };
//         int n = arr.Length;
//         Console.WriteLine("All Subarrays:\n");

//         // Pick starting index
//         for (int start = 0; start < n; start++)
//         {
//             // Pick ending index
//             for (int end = start; end < n; end++)
//             {
//                 // Print elements from start to end
//                 for (int k = start; k <= end; k++)
//                 {
//                     Console.Write(arr[k] + " ");
//                 }
//                 Console.WriteLine();
//             }
//         }
//     }
// }


//  printing subarray using two loops

// using System;
// class SubarraysTwoLoops
// {
//     static void Main()
//     {
//         int[] arr = { 10, 20, 30, 40 };
//         int n = arr.Length;
//         Console.WriteLine("All Subarrays (2 loops):\n");

//         // Start index
//         for (int start = 0; start < n; start++)
//         {
//             string subarray = "";
//             // End index
//             for (int end = start; end < n; end++)
//             {
//                 // Extend subarray
//                 subarray += arr[end] + " ";
//                 Console.WriteLine(subarray);
//             }
//         }
//     }
// }


// 3. Sum of All Subarrays
// Question:
// Find the sum of all subarrays of the given array.
// Input:
// arr = [1, 2]
// Output:
// 6
// (Subarrays: [1], [2], [1,2] → Sum = 1+2+3)
// using System;
// class SumAllSubarraysTwoLoops
// {
//     static void Main()
//     {
//         int[] arr = { 1, 2 };
//         int n = arr.Length;

//         int totalSum = 0;

//         for (int start = 0; start < n; start++)
//         {
//             int runningSum = 0;

//             for (int end = start; end < n; end++)
//             {
//                 runningSum += arr[end];
//                 totalSum += runningSum;
//             }
//         }

//         Console.WriteLine("Sum of all subarrays = " + totalSum);
//     }
// }


// 6. Count Subarrays with Sum = K
// Question:
// Count all subarrays whose sum equals K.
// Input:
// arr = [1, 2, 1] , K = 3
// Output:
// 2
// ([1,2], [2,1])
