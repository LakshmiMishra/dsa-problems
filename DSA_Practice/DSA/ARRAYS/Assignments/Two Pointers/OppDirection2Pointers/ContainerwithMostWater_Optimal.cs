using System;

public class Program
{
    public static void Main()
    {
        // Container with Most Water - Optimal (Two Pointer Approach)
        int[] heights = { 1, 8, 6, 2, 5, 4, 8, 3, 9 };
        int maxArea = FindMaxArea(heights);
        Console.WriteLine($"Maximum area of water that can be contained: {maxArea}");
    }
    
    public static int FindMaxArea(int[] heights)
    {
        int maxArea = int.MinValue;
        int left = 0;
        int right = heights.Length - 1;
        
        while (left < right)
        {
            // Area = width × minimum height
            int currentArea = (right - left) * Math.Min(heights[left], heights[right]);
            maxArea = Math.Max(currentArea, maxArea);
            
            // Move the pointer pointing to the smaller height
            if (heights[left] < heights[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }
        
        return maxArea;
    }
}