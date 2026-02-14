// Given an array of integers nums and an integer target,
// return indices of the two numbers such that they add up to target.
// You may assume that each input would have exactly one solution, and you may not use the same element twice.
// You can return the answer in any order.
// Example 1:
// Input: nums = [2,7,11,15], target = 9
// Output: [0,1]
// Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
// Example 2:
// Input: nums = [3,2,4], target = 6
// Output: [1,2]
// Example 3:
// Input: nums = [3,3], target = 6
// Output: [0,1]
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
		 int [] arr={2,7,9,1,3,1,8,-3};
		 int target=5;
	  //Logic here is we will start from index 0 and since we already have a target sum, we will already know the compliment of the index.
  // We will first check dictinary , whether the compliment of the the arry value exists or not
  //if not, we will save the arr value as key and  with its index value as value
  //we will keep on doing the same ,untill we find the complient value of the arr element which sum as target
	Dictionary<int,int> dic=new Dictionary<int,int>();
	for(int i=0;i<arr.Length-1;i++){
	  int otherVal=target-arr[i];//this is the complement of the arry elemt which makes target-arr
	  if(!dic.ContainsKey(otherVal))
	  {
	    //if the array element do not exists in the dictionary, then add 
	    dic.Add(arr[i],i);
	  }
	  else
	  {
	    //if the array elemt exists in the dictionary 
	    //then
	    Console.Write(i+","+dic[otherVal]);
	    break;
	   
	  }
	}
	
		}
	}
}