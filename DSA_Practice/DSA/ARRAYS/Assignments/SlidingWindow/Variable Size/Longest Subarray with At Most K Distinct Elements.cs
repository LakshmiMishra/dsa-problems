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
// 10. Longest Subarray with At Most K Distinct Elements
// Problem Statement:
// You are given an array of integers and an integer K. Determine the maximum length of a contiguous subarray that contains at most K distinct integers.
// Input:
// Array = [1, 2, 1, 2, 3]
// K = 2
// Output:
// 4

//int[] arr={1, 2, 1, 2, 3};
int [] arr={1,1,1,1,1,1,1,9,2,3,2};
int slow=0;
int maxL=0;
int k=2;
var dict =new Dictionary<int,int>();


for(int fast=0;fast<arr.Length;fast++){

if(!dict.ContainsKey(arr[fast])){
  dict.Add(arr[fast],0);
 
}
 dict[arr[fast]]++;//increase the frequency
  
//condition check for maintaing the valid window
while(dict.Count>k)//if dict is holding more than k elements then shrik the window
{
  dict[arr[slow]]--;//decrease the first elemt frequency 
  //if there is no more element left then remove from dict
  if(dict[arr[slow]]==0)
  dict.Remove(arr[slow]);
  slow++;
  
}
maxL=Math.Max(fast-slow+1,maxL);
}
Console.WriteLine(maxL);
		}
	}
}