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
// 			12. Count Subarrays with At Most K Distinct Integers
// Problem Statement:
// You are given an array of integers and an integer K. 
//Count the total number of contiguous subarrays that contain at most K distinct integers.
// Input:
// Array = [1, 2, 1, 2, 3]
// K = 2
// Output:
// 12
int slow=0;
int counter=0;
int k=2;
int [] arr={1,2,1,2,3};
var dict=new Dictionary<int,int>();

for(int fast=0;fast<arr.Length;fast++){
  
          if(!dict.ContainsKey(arr[fast]))
          {
            dict.Add(arr[fast],0);
          }
          dict[arr[fast]]++; // increase the freq of the element
//now we need to grow or shrink the window 
//by checking the condition
//dictionary should have at most k disticnct element 
          while(dict.Count>k){
            dict[arr[slow]]--;//decrease the freq of the element
             if(dict[arr[slow]]==0)//0 freq
            dict.Remove(arr[slow]);
            slow++;
          
           }
           if(dict.Count<=k)
             counter+=fast-slow+1;

}Console.Write(counter);
		}
		
	}
}