//Can you find a subarray whose sum equals a given target?
//Array contains all positive integers, so we can use sliding window approach to solve this problem in O(n) time complexity.
//We will maintain a sliding window and keep adding elements to the window until the sum is less
// Return the 1-based indices of the start and end.
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
	//	int[] arr={1, 2, 3, 7, 5 };
		//int target=12;
		int[] arr={15, 2, 4, 8, 9, 5, 10, 23 };
		int target=23;
		int cSum=0;
		int slow=0;
		
		for(int fast=0;fast<arr.Length;fast++){
		  cSum+=arr[fast];
		  while(cSum>target){
		    cSum-=arr[slow];
		    slow++;
		  }
		  if(cSum==target){
		    Console.WriteLine("1-Indices based index are {0} and {1}",slow+1,fast+1);
		    return;
		  }
		}
        Console.WriteLine("No such subarray exists");
		}
	}
}