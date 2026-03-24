using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
	public class Program
	{
		public static void Main(string[] args)
		{
// 9. Smallest Subarray with Sum Greater Than or Equal to K
// Problem Statement:
// Given an array of positive integers and an integer K, find the minimum length of a contiguous subarray whose sum is greater than or equal to K.
// Input:
// Array = [2, 1, 5, 2, 3, 2]
// K = 7
// Output:
// 2
int[] arr={2,1,5,2,3,2};
int slow=0;
int minL=int.MaxValue;
int curSum=0;
int target=7;

for(int fast=0;fast<arr.Length;fast++){
  curSum+=arr[fast];
  int curL=0;
  while(curSum>=target)
  {
    //we found our condition satisfied candidate
    //take out the min Length
    curL=fast-slow+1;
    minL=Math.Min(curL,minL);
    //once the subarray min length is saved , shrink the window
    curSum-=arr[slow];
    slow++;
  }
}
Console.WriteLine(minL);
		}
	}
}