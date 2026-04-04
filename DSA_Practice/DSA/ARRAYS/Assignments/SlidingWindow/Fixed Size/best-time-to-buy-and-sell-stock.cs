

// 	You are given an array prices where prices[i] is the price of a given stock on the ith day.

// You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.

// Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.
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
			int[] arr={1,2,4,2,5,7,2,4,9,0,9};
			int slow=0;
			int mp=0;
			int curDiff=0;
			for(int fast=1;fast<arr.Length;fast++){
			  curDiff=arr[fast]-arr[slow];
			  if(arr[fast]<arr[slow])
			  {
			  curDiff=0;
			  slow=fast;
			  }
			  else
			  mp=Math.Max(mp,curDiff);
			  
			}
			Console.Write(mp);
		}
	}
}
