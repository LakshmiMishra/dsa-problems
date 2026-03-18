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
		  //Longest Subarray with Sum Less Than or Equal to K
		int [] arr={2, 1, 5, 1, 3, 2};
		int targetSum=7;
		int start=0;
	
		int n=arr.Length;
		int maxLen=0;
		int curLeng=0;
		int curSum=0;
	// Maximum sum subarray having sum less than or equal to given sum
//	maximum , subarray , <=k ==> sliding window with variable size
	for(int end=0;end<n;end++){
	   curSum+=arr[end];
	   while(curSum>targetSum){
	   //if the sum is greater delete the left values
	   curSum-=arr[start];
	   start++;//shrink the window
	 
	   }
	   maxLen=Math.Max(maxLen,end-start+1);

	  }
	  Console.WriteLine("Longest Subarray Length having Sum <=K is :"+maxLen);
		
		}
	}
}