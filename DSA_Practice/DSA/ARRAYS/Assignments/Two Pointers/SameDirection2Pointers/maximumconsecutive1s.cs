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
// 			Q6. Find maximum consecutive ones
// Problem Statement:
// Given a binary array, find the maximum number of consecutive 1s.
// Input:
// arr = [1, 1, 0, 1, 1, 1,1]
// Output:
// 4
int[] arr={1,1,0,1,1,1,1};
//int [] arr={1, 1, 1, 0, 1, 1};
//int[] arr={0,0,0};
int n=arr.Length;
int maxLen=0;
int cl=0;
for(int fast=0;fast<n;fast++){

if(arr[fast]==1)
{

  cl++;
  maxLen=Math.Max(cl,maxLen);

}
else
{
  cl=0;
}

}
Console.Write(maxLen);
}
	  
	}
  
}
