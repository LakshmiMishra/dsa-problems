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
		int [] arr={2, 1, 5, 1, 3, 2};
		int targetSum=7;
		int start=0;
		int end=0;
		int n=arr.Length;
		int maxSum=int.MinValue;
		int curSum=0;
	// Maximum sum subarray having sum less than or equal to given sum
//	maximum , subarray , <=k ==> sliding window with variable size
	while(end<n){
	   curSum+=arr[end];
	   while(curSum>targetSum){
	   //if the sum is greater delete the left values
	   curSum-=arr[start];
	   start++;//shrink the window
	   
	   }
	   maxSum=Math.Max(maxSum,curSum);
	   end++;
	  }
	  Console.WriteLine("Maximum Sum Subarray having Sum <=K is :"+maxSum);
		
		}
	}
}