
//Given an array nums of size n, return the majority element.

//The majority element is the element that appears more than ⌊n / 2⌋ times. You may assume that the majority element always exists in the array.
// Example 1:

// Input: nums = [3,2,3]
// Output: 3
// Example 2:

// Input: nums = [2,2,1,1,1,2,2]
// Output: 2
 

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
			int[] nums={2,2,1,1,1,2,2};
			int n=nums.Length;
			int majElement=int.MinValue;
		    for(int i=0;i<n;i++){
		      int freq=0;
		      //check whether the array elements occur how many times 
		      for(int j=0;j<n;j++){
		        if(nums[i]==nums[j])
		        freq++;
		      }
		      if(freq>n/2)
		      majElement=nums[i];
		    }
		   // return majElement;
		   Console.Write("Majority Element in the array is {0}",majElement);
		}
	}
}