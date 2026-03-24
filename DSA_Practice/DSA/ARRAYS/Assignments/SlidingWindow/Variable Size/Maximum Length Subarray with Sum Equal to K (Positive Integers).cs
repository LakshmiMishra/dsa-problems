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
// 13. Maximum Length Subarray with Sum Equal to K (Positive Integers)
// Problem Statement:
// Given an array containing only positive integers and a value K, determine the maximum length of a contiguous subarray whose sum is exactly K.
// Input:
// Array = [4, 1, 1, 1, 2, 3, 5]
// K = 5
// Output:
// 4


//int[] arr={1, 2, 1, 2, 3};
int [] arr={4, 1, 1, 1, 2, 3, 5};
int slow=0;
int maxL=0;
int k=5;
int curSum=0;

//Sliding window positive numbers

for(int fast=0;fast<arr.Length;fast++){
  
  curSum+=arr[fast];
 
  while(curSum>k){
 
  curSum-=arr[slow];
  slow++;
  
  }
    // check if we hit target
        if (curSum == k)
        {
            maxL=Math.Max(maxL,fast-slow+1);
        }
  
}


Console.WriteLine(maxL);
		}
	}
}