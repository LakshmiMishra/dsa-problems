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
// . Longest Subarray with Sum Less Than or Equal to K
// Problem Statement:
// You are given an array of positive integers and an integer K. 
//Find the length of the longest contiguous subarray 
//whose sum of elements is less than or equal to K.
// Input:
// Array = [2, 1, 5, 1, 3, 2]
// K = 7
// Output:3
int[] arr={2,1,5,2,3,2};
int slow=0;
int maxL=int.MinValue;
int curSum=0;
int k=7;

for(int fast=0;fast<arr.Length;fast++){
   curSum+=arr[fast];
   
  while(curSum>k){ 
   curSum-=arr[slow];
   slow++;
  }
  int curL=0;
   curL=fast-slow+1;
   maxL=Math.Max(curL,maxL);
}
Console.WriteLine(maxL);
		}
	}
}