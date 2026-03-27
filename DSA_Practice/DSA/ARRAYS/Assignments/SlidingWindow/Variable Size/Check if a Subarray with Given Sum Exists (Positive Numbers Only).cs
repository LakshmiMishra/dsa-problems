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
// 			14. Check if a Subarray with Given Sum Exists (Positive Numbers Only)
// Problem Statement:
// You are given an array of positive integers and a target sum K. Determine whether there exists a contiguous subarray whose sum is exactly equal to K.
// Input:
// Array = [1, 4, 20, 3, 10, 5]
// K = 33
// Output:
// Yes
int[] arr={1, 4, 20, 3, 10, 5};
int slow=0;
int curSum=0;
int k=33;
if(arr.Length==0)
{
    Console.WriteLine("No");
    return;
}
for(int fast=0;fast<arr.Length;fast++){
    if(arr[fast]<0)
    {
        Console.WriteLine("Invalid input");
        return;
    }
    if(arr[fast]>k)
    {
        Console.WriteLine("No");
        return;
    }
    if(arr[fast]==k)
    {
        Console.WriteLine("Yes");
        return;
    }

  curSum+=arr[fast];
  while(curSum>k){
    curSum-=arr[slow];
    slow++;
    
  }
  if(curSum==k){
  Console.WriteLine("Yes");
  break;
  }
  
}

		}
	}
}