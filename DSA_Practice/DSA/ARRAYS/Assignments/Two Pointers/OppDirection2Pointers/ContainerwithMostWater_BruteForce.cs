using System;

public class Program
{
    public static void Main()
    {
        // Container with Most Water - Brute Force (check all pairs)
        int[] heights = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
        int maxArea = FindMaxAreaBruteForce(heights);
        Console.WriteLine($"Maximum area of water that can be contained: {maxArea}");
    }
    
    public static int FindMaxAreaBruteForce(int[] heights)
    {
        int maxArea = int.MinValue;
        int n = heights.Length;
        
        // Check every pair of indices
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                // Area = width × minimum height
                int currentArea = (j - i) * Math.Min(heights[i], heights[j]);
                maxArea = Math.Max(currentArea, maxArea);
            }
        }
        
        return maxArea;
    }
}