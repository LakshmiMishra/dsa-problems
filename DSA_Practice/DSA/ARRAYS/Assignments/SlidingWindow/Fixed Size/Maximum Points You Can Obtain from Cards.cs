public class Solution {
    public int MaxScore(int[] arr, int k) {

        ///issue 
             int n = arr.Length;
        if (n < k) return -1;

        // compute sum of first window
        int windowSum = 0;
        for (int i = 0; i < k; i++) {
            windowSum += arr[i];
        }

        int maxSum = windowSum;

        // slide the window
        for (int i = k; i < n; i++) {
            windowSum += arr[i] - arr[i - k];
            maxSum = Math.Max(maxSum, windowSum);
        }

        return maxSum;
    }

     static void Main() {
        int[] arr = {1,2,3,4,5,6,1};
        int k = 3;
        Console.WriteLine(MaxScore(arr, k));
    }
}